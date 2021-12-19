using System;
using System.Diagnostics;
using System.Threading;

namespace Vulkan
{
    public sealed class FpsControl
    {
        private readonly Stopwatch m_Ellapsed;
        private readonly double m_targetFps;
        private readonly double m_FrameTime;

        private int m_FrameCount;
        private double m_MeanIdleTimeMs;
        private bool m_Enabled;

        public FpsControl()
            : this(30)
        {
        }

        public FpsControl(int targetFps)
        {
            m_FrameCount = 0;
            m_targetFps = targetFps;
            m_Ellapsed = new Stopwatch();
            m_Ellapsed.Start();

            m_FrameTime = 1000f / m_targetFps;
        }

        public bool Enabled
        {
            get { return m_Enabled; }
            set { UpdateState(value); }
        }

        private void UpdateState(bool enabled)
        {
            if (enabled == m_Enabled)
                return;

            if (enabled)
            {
                m_Ellapsed.Restart();
                m_FrameCount = 0;
                m_Enabled = enabled;
            }
            else
            {
                m_Enabled = enabled;
                m_Ellapsed.Stop();
            }
        }

        public void Update()
        {
            int timeToSleep = 1;

            if (Enabled)
            {
                m_FrameCount++;
                var calculatedEllapsedMs = m_FrameTime * m_FrameCount;
                var timeDiff = calculatedEllapsedMs - m_Ellapsed.ElapsedMilliseconds;

                TestReset();

                if (timeDiff >= 1)
                {
                    m_MeanIdleTimeMs = (m_MeanIdleTimeMs + timeDiff) / 2;
                    timeToSleep = (int)Math.Max(timeDiff, m_FrameTime);
                }
            }

            Thread.Sleep(timeToSleep);
        }

        private void Reset()
        {
            m_Ellapsed.Restart();
            m_FrameCount = 0;
        }

        private void TestReset()
        {
            if (m_Ellapsed.ElapsedMilliseconds > 1000)
                Reset();
        }
    }
}
