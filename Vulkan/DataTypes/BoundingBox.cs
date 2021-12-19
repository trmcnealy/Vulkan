
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    /// <summary>
    /// Represents an axis-aligned bounding box in three dimensional space.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct BoundingBox : IEquatable<BoundingBox>, IFormattable
    {
        /// <summary>
        /// The minimum point of the box.
        /// </summary>
        public Vector3F Minimum;

        /// <summary>
        /// The maximum point of the box.
        /// </summary>
        public Vector3F Maximum;

        /// <summary>
        /// The mid point of the box.
        /// </summary>
        public Vector3F Center;

        public BoundingBox(Vector3F[] points)
        {
            float minX = MathExtensions.Min(points.Select(item => item.X).ToArray());
            float minY = MathExtensions.Min(points.Select(item => item.Y).ToArray());
            float minZ = MathExtensions.Min(points.Select(item => item.Z).ToArray());

            float maxX = MathExtensions.Max(points.Select(item => item.X).ToArray());
            float maxY = MathExtensions.Max(points.Select(item => item.Y).ToArray());
            float maxZ = MathExtensions.Max(points.Select(item => item.Z).ToArray());

            Minimum = new Vector3F(minX, minY, minZ);
            Maximum = new Vector3F(maxX, maxY, maxZ);

            if (!Minimum.IsNaN() && !Maximum.IsNaN())
            {
                float xMid = (Minimum.X + Maximum.X) * 0.5f;
                float yMid = (Minimum.Y + Maximum.Y) * 0.5f;
                float zMid = (Minimum.Z + Maximum.Z) * 0.5f;

                Center = new Vector3F(xMid, yMid, zMid);
            }
            else
            {
                Center = new Vector3F(float.NaN, float.NaN, float.NaN);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBox"/> struct.
        /// </summary>
        /// <param name="minimum">The minimum vertex of the bounding box.</param>
        /// <param name="maximum">The maximum vertex of the bounding box.</param>
        public BoundingBox(Vector3F minimum, Vector3F maximum)
        {
            Minimum = minimum;
            Maximum = maximum;

            if (!Minimum.IsNaN() && !Maximum.IsNaN())
            {
                float xMid = (Minimum.X + Maximum.X) * 0.5f;
                float yMid = (Minimum.Y + Maximum.Y) * 0.5f;
                float zMid = (Minimum.Z + Maximum.Z) * 0.5f;

                Center = new Vector3F(xMid, yMid, zMid);
            }
            else
            {
                Center = new Vector3F(float.NaN, float.NaN, float.NaN);
            }
        }

        public float this[int i, int j]
        {
            get
            {
                Vector3F vector;

                if (i == 0)
                {
                    vector = Minimum;
                }
                else
                {
                    vector = Maximum;
                }

                switch (j)
                {
                    case 0:
                    {
                        return vector.X;
                    }
                    case 1:
                    {
                        return vector.Y;
                    }
                    case 2:
                    {
                        return vector.Z;
                    }
                }

                return float.NaN;
            }
        }

        /// <summary>
        /// Retrieves the eight corners of the bounding box.
        /// </summary>
        /// <returns>An array of points representing the eight corners of the bounding box.</returns>
        public Vector3F[] GetCorners()
        {
            Vector3F[] results = new Vector3F[8];
            GetCorners(results);
            return results;
        }

        /// <summary>
        /// Retrieves the eight corners of the bounding box.
        /// </summary>
        /// <returns>An array of points representing the eight corners of the bounding box.</returns>
        public void GetCorners(Vector3F[] corners)
        {
            corners[0] = new Vector3F(Minimum.X, Maximum.Y, Maximum.Z);
            corners[1] = new Vector3F(Maximum.X, Maximum.Y, Maximum.Z);
            corners[2] = new Vector3F(Maximum.X, Minimum.Y, Maximum.Z);
            corners[3] = new Vector3F(Minimum.X, Minimum.Y, Maximum.Z);
            corners[4] = new Vector3F(Minimum.X, Maximum.Y, Minimum.Z);
            corners[5] = new Vector3F(Maximum.X, Maximum.Y, Minimum.Z);
            corners[6] = new Vector3F(Maximum.X, Minimum.Y, Minimum.Z);
            corners[7] = new Vector3F(Minimum.X, Minimum.Y, Minimum.Z);
        }

        public List<Vector3F> GetPoints()
        {
            List<Vector3F> corners = new List<Vector3F>(8);

            corners.Add(new Vector3F(Minimum.X, Maximum.Y, Maximum.Z));
            corners.Add(new Vector3F(Maximum.X, Maximum.Y, Maximum.Z));
            corners.Add(new Vector3F(Maximum.X, Minimum.Y, Maximum.Z));
            corners.Add(new Vector3F(Minimum.X, Minimum.Y, Maximum.Z));
            corners.Add(new Vector3F(Minimum.X, Maximum.Y, Minimum.Z));
            corners.Add(new Vector3F(Maximum.X, Maximum.Y, Minimum.Z));
            corners.Add(new Vector3F(Maximum.X, Minimum.Y, Minimum.Z));
            corners.Add(new Vector3F(Minimum.X, Minimum.Y, Minimum.Z));

            return corners;
        }

        public List<Tuple<Vector3F, Vector3F>> GetQuads()
        {
            //List<Tuple<Vector3F, Vector3F>> quads = new List<Tuple<Vector3F, Vector3F>>();

            //1
            Vector3F upperBackRightMax = new Vector3F(Maximum.X, Maximum.Y, Maximum.Z);
            Vector3F upperBackRightMin = new Vector3F(Center.X, Center.Y, Center.Z);
            Tuple<Vector3F, Vector3F> upperBackRight = new Tuple<Vector3F, Vector3F>(upperBackRightMax, upperBackRightMin);
            //2
            Vector3F upperFrontRightMax = new Vector3F(Maximum.X, Center.Y, Maximum.Z);
            Vector3F upperFrontRightMin = new Vector3F(Center.X, Minimum.Y, Center.Z);
            Tuple<Vector3F, Vector3F> upperFrontRight = new Tuple<Vector3F, Vector3F>(upperFrontRightMax, upperFrontRightMin);
            //3
            Vector3F upperFrontLeftMax = new Vector3F(Center.X, Center.Y, Maximum.Z);
            Vector3F upperFrontLeftMin = new Vector3F(Minimum.X, Minimum.Y, Center.Z);
            Tuple<Vector3F, Vector3F> upperFrontLeft = new Tuple<Vector3F, Vector3F>(upperFrontLeftMax, upperFrontLeftMin);
            //4
            Vector3F upperBackLeftMax = new Vector3F(Center.X, Maximum.Y, Maximum.Z);
            Vector3F upperBackLeftMin = new Vector3F(Minimum.X, Center.Y, Center.Z);
            Tuple<Vector3F, Vector3F> upperBackLeft = new Tuple<Vector3F, Vector3F>(upperBackLeftMax, upperBackLeftMin);
            //5
            Vector3F lowerBackRightMax = new Vector3F(Maximum.X, Maximum.Y, Center.Z);
            Vector3F lowerBackRightMin = new Vector3F(Center.X, Center.Y, Minimum.Z);
            Tuple<Vector3F, Vector3F> lowerBackRight = new Tuple<Vector3F, Vector3F>(lowerBackRightMax, lowerBackRightMin);
            //6
            Vector3F lowerFrontRightMax = new Vector3F(Maximum.X, Center.Y, Center.Z);
            Vector3F lowerFrontRightMin = new Vector3F(Center.X, Minimum.Y, Minimum.Z);
            Tuple<Vector3F, Vector3F> lowerFrontRight = new Tuple<Vector3F, Vector3F>(lowerFrontRightMax, lowerFrontRightMin);
            //7
            Vector3F lowerFrontLeftMax = new Vector3F(Center.X, Center.Y, Center.Z);
            Vector3F lowerFrontLeftMin = new Vector3F(Minimum.X, Minimum.Y, Minimum.Z);
            Tuple<Vector3F, Vector3F> lowerFrontLeft = new Tuple<Vector3F, Vector3F>(lowerFrontLeftMax, lowerFrontLeftMin);
            //8
            Vector3F lowerBackLeftMax = new Vector3F(Center.X, Maximum.Y, Center.Z);
            Vector3F lowerBackLeftMin = new Vector3F(Minimum.X, Center.Y, Minimum.Z);
            Tuple<Vector3F, Vector3F> lowerBackLeft = new Tuple<Vector3F, Vector3F>(lowerBackLeftMax, lowerBackLeftMin);

            return new List<Tuple<Vector3F, Vector3F>>() { upperBackRight, upperFrontRight, upperFrontLeft, upperBackLeft, lowerBackRight, lowerFrontRight, lowerBackLeft, lowerFrontLeft };
        }

        /// <summary>
        /// Determines if there is an intersection between the current object and a <see cref="Ray"/>.
        /// </summary>
        /// <param name="ray">The ray to test.</param>
        /// <returns>Whether the two objects intersected.</returns>
        //public bool Intersects(ref Ray ray)
        //{
        //    double distance;
        //    return Collision.RayIntersectsBox(ref ray, ref this, out distance);
        //}

        /// <summary>
        /// Determines if there is an intersection between the current object and a <see cref="Ray"/>.
        /// </summary>
        /// <param name="ray">The ray to test.</param>
        /// <param name="distance">When the method completes, contains the distance of the intersection,
        /// or 0 if there was no intersection.</param>
        /// <returns>Whether the two objects intersected.</returns>
        //public bool Intersects(ref Ray ray, out double distance)
        //{
        //    return Collision.RayIntersectsBox(ref ray, ref this, out distance);
        //}

        /// <summary>
        /// Determines if there is an intersection between the current object and a <see cref="Ray"/>.
        /// </summary>
        /// <param name="ray">The ray to test.</param>
        /// <param name="point">When the method completes, contains the point of intersection,
        /// or <see cref="Vector3F.Zero"/> if there was no intersection.</param>
        /// <returns>Whether the two objects intersected.</returns>
        //public bool Intersects(ref Ray ray, out Vector3F point)
        //{
        //    return Collision.RayIntersectsBox(ref ray, ref this, out point);
        //}

        ///// <summary>
        ///// Determines if there is an intersection between the current object and a <see cref="Plane3D"/>.
        ///// </summary>
        ///// <param name="plane">The plane to test.</param>
        ///// <returns>Whether the two objects intersected.</returns>
        //public PlaneIntersectionType Intersects(ref Plane3F plane)
        //{
        //    return Infrastructure.Collision.PlaneIntersectsBox(ref plane, ref this);
        //}

        /* This implementation is wrong
        /// <summary>
        /// Determines if there is an intersection between the current object and a triangle.
        /// </summary>
        /// <param name="vertex1">The first vertex of the triangle to test.</param>
        /// <param name="vertex2">The second vertex of the triangle to test.</param>
        /// <param name="vertex3">The third vertex of the triangle to test.</param>
        /// <returns>Whether the two objects intersected.</returns>
        public bool Intersects(ref Vector3F vertex1, ref Vector3F vertex2, ref Vector3F vertex3)
        {
            return Collision.BoxIntersectsTriangle(ref this, ref vertex1, ref vertex2, ref vertex3);
        }
        */

        ///// <summary>
        ///// Determines if there is an intersection between the current object and a <see cref="BoundingBox"/>.
        ///// </summary>
        ///// <param name="box">The box to test.</param>
        ///// <returns>Whether the two objects intersected.</returns>
        //public bool Intersects(ref BoundingBox box)
        //{
        //    return Infrastructure.Collision.BoxIntersectsBox(ref this, ref box);
        //}

        ///// <summary>
        ///// Determines if there is an intersection between the current object and a <see cref="BoundingBox"/>.
        ///// </summary>
        ///// <param name="box">The box to test.</param>
        ///// <returns>Whether the two objects intersected.</returns>
        //public bool Intersects(BoundingBox box)
        //{
        //    return Intersects(ref box);
        //}

        /// <summary>
        /// Determines if there is an intersection between the current object and a <see cref="BoundingSphere"/>.
        /// </summary>
        /// <param name="sphere">The sphere to test.</param>
        /// <returns>Whether the two objects intersected.</returns>
        //public bool Intersects(ref BoundingSphere sphere)
        //{
        //    return Collision.BoxIntersectsSphere(ref this, ref sphere);
        //}

        /// <summary>
        /// Determines if there is an intersection between the current object and a <see cref="BoundingSphere"/>.
        /// </summary>
        /// <param name="sphere">The sphere to test.</param>
        /// <returns>Whether the two objects intersected.</returns>
        //public bool Intersects(BoundingSphere sphere)
        //{
        //    return Intersects(ref sphere);
        //}

        ///// <summary>
        ///// Determines whether the current objects contains a point.
        ///// </summary>
        ///// <param name="point">The point to test.</param>
        ///// <returns>The type of containment the two objects have.</returns>
        //public ContainmentType Contains(ref Vector3F point)
        //{
        //    return Infrastructure.Collision.BoxContainsPoint(ref this, ref point);
        //}

        ///// <summary>
        ///// Determines whether the current objects contains a point.
        ///// </summary>
        ///// <param name="point">The point to test.</param>
        ///// <returns>The type of containment the two objects have.</returns>
        //public ContainmentType Contains(Vector3F point)
        //{
        //    return Contains(ref point);
        //}

        /* This implementation is wrong
        /// <summary>
        /// Determines whether the current objects contains a triangle.
        /// </summary>
        /// <param name="vertex1">The first vertex of the triangle to test.</param>
        /// <param name="vertex2">The second vertex of the triangle to test.</param>
        /// <param name="vertex3">The third vertex of the triangle to test.</param>
        /// <returns>The type of containment the two objects have.</returns>
        public ContainmentType Contains(ref Vector3F vertex1, ref Vector3F vertex2, ref Vector3F vertex3)
        {
            return Collision.BoxContainsTriangle(ref this, ref vertex1, ref vertex2, ref vertex3);
        }
        */

        ///// <summary>
        ///// Determines whether the current objects contains a <see cref="BoundingBox"/>.
        ///// </summary>
        ///// <param name="box">The box to test.</param>
        ///// <returns>The type of containment the two objects have.</returns>
        //public ContainmentType Contains(ref BoundingBox box)
        //{
        //    return Infrastructure.Collision.BoxContainsBox(ref this, ref box);
        //}

        ///// <summary>
        ///// Determines whether the current objects contains a <see cref="BoundingBox"/>.
        ///// </summary>
        ///// <param name="box">The box to test.</param>
        ///// <returns>The type of containment the two objects have.</returns>
        //public ContainmentType Contains(BoundingBox box)
        //{
        //    return Contains(ref box);
        //}

        /// <summary>
        /// Determines whether the current objects contains a <see cref="BoundingSphere"/>.
        /// </summary>
        /// <param name="sphere">The sphere to test.</param>
        /// <returns>The type of containment the two objects have.</returns>
        //public ContainmentType Contains(ref BoundingSphere sphere)
        //{
        //    return Collision.BoxContainsSphere(ref this, ref sphere);
        //}

        /// <summary>
        /// Determines whether the current objects contains a <see cref="BoundingSphere"/>.
        /// </summary>
        /// <param name="sphere">The sphere to test.</param>
        /// <returns>The type of containment the two objects have.</returns>
        //public ContainmentType Contains(BoundingSphere sphere)
        //{
        //    return Contains(ref sphere);
        //}

        /// <summary>
        /// Constructs a <see cref="BoundingBox"/> that fully contains the given points.
        /// </summary>
        /// <param name="points">The points that will be contained by the box.</param>
        /// <param name="result">When the method completes, contains the newly constructed bounding box.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="points"/> is <c>null</c>.</exception>
        public static void FromPoints(Vector3F[] points, out BoundingBox result)
        {
            if (points == null)
                throw new ArgumentNullException("points");

            Vector3F min = new Vector3F(float.MaxValue);
            Vector3F max = new Vector3F(float.MinValue);

            for (int i = 0; i < points.Length; ++i)
            {
                min = Vector3F.Min(min, points[i]);
                max = Vector3F.Max(max, points[i]);
            }

            result = new BoundingBox(min, max);
        }

        /// <summary>
        /// Constructs a <see cref="BoundingBox"/> that fully contains the given points.
        /// </summary>
        /// <param name="points">The points that will be contained by the box.</param>
        /// <returns>The newly constructed bounding box.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="points"/> is <c>null</c>.</exception>
        public static BoundingBox FromPoints(Vector3F[] points)
        {
            if (points == null)
                throw new ArgumentNullException("points");

            Vector3F min = new Vector3F(float.MaxValue);
            Vector3F max = new Vector3F(float.MinValue);

            for (int i = 0; i < points.Length; ++i)
            {
                min = Vector3F.Min(min, points[i]);
                max = Vector3F.Max(max, points[i]);
            }

            return new BoundingBox(min, max);
        }

        //public static BoundingBox FromPoints(Vector3F[] points)
        //{
        //    if(points == null)
        //        throw new ArgumentNullException("points");

        //    Vector3F min = new Vector3F(float.MaxValue);
        //    Vector3F max = new Vector3F(float.MinValue);

        //    for(int i = 0; i < points.Length; ++i)
        //    {
        //        min = Vector3F.Min(min, points[i]);
        //        max = Vector3F.Max(max, points[i]);
        //    }

        //    return new BoundingBox(min, max);
        //}

        /// <summary>
        /// Constructs a <see cref="BoundingBox"/> from a given sphere.
        /// </summary>
        /// <param name="sphere">The sphere that will designate the extents of the box.</param>
        /// <param name="result">When the method completes, contains the newly constructed bounding box.</param>
        //public static void FromSphere(ref BoundingSphere sphere, out BoundingBox result)
        //{
        //    result.Minimum = new Vector3F(sphere.Center.X - sphere.Radius, sphere.Center.Y - sphere.Radius, sphere.Center.Z - sphere.Radius);
        //    result.Maximum = new Vector3F(sphere.Center.X + sphere.Radius, sphere.Center.Y + sphere.Radius, sphere.Center.Z + sphere.Radius);
        //}

        /// <summary>
        /// Constructs a <see cref="BoundingBox"/> from a given sphere.
        /// </summary>
        /// <param name="sphere">The sphere that will designate the extents of the box.</param>
        /// <returns>The newly constructed bounding box.</returns>
        //public static BoundingBox FromSphere(BoundingSphere sphere)
        //{
        //    BoundingBox box;
        //    box.Minimum = new Vector3F(sphere.Center.X - sphere.Radius, sphere.Center.Y - sphere.Radius, sphere.Center.Z - sphere.Radius);
        //    box.Maximum = new Vector3F(sphere.Center.X + sphere.Radius, sphere.Center.Y + sphere.Radius, sphere.Center.Z + sphere.Radius);
        //    return box;
        //}

        /// <summary>
        /// Constructs a <see cref="BoundingBox"/> that is as large as the total combined area of the two specified boxes.
        /// </summary>
        /// <param name="value1">The first box to merge.</param>
        /// <param name="value2">The second box to merge.</param>
        /// <param name="result">When the method completes, contains the newly constructed bounding box.</param>
        public static void Merge(ref BoundingBox value1, ref BoundingBox value2, out BoundingBox result)
        {
            result = new BoundingBox
            {
                Minimum = Vector3F.Min(value1.Minimum, value2.Minimum),
                Maximum = Vector3F.Max(value1.Maximum, value2.Maximum)
            };
        }

        /// <summary>
        /// Constructs a <see cref="BoundingBox"/> that is as large as the total combined area of the two specified boxes.
        /// </summary>
        /// <param name="value1">The first box to merge.</param>
        /// <param name="value2">The second box to merge.</param>
        /// <returns>The newly constructed bounding box.</returns>
        public static BoundingBox Merge(BoundingBox value1, BoundingBox value2)
        {
            BoundingBox box = new BoundingBox
            {
                Minimum = Vector3F.Min(value1.Minimum, value2.Minimum),
                Maximum = Vector3F.Max(value1.Maximum, value2.Maximum)
            };
            return box;
        }


        public static Vector3F HalfSize(BoundingBox bbox)
        {
            return BoundingBox.Size(bbox) * 0.5f;
        }

        public static Vector3F Size(BoundingBox bbox)
        {
            return bbox.Maximum - bbox.Minimum;
        }

        public static float Volume(BoundingBox bbox)
        {
            Vector3F s = Size(bbox);
            return s.X * s.Y * s.Z;
        }

        public static float SurfaceArea(BoundingBox bbox)
        {
            Vector3F s = BoundingBox.Size(bbox);
            return (s.X * s.Y + s.X * s.Z + s.Y * s.Z) * 2;
        }


        /// <summary>
        /// Tests for equality between two objects.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> has the same value as <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(BoundingBox left, BoundingBox right)
        {
            return left.Equals(ref right);
        }

        /// <summary>
        /// Tests for inequality between two objects.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><c>true</c> if <paramref name="left"/> has a different value than <paramref name="right"/>; otherwise, <c>false</c>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(BoundingBox left, BoundingBox right)
        {
            return !left.Equals(ref right);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "Minimum:{0} Maximum:{1}", Minimum.ToString(), Maximum.ToString());
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public string ToString(string? format)
        {
            if (format == null)
            {
                return ToString();
            }

            return string.Format(CultureInfo.CurrentCulture, "Minimum:{0} Maximum:{1}", Minimum.ToString(format, CultureInfo.CurrentCulture), Maximum.ToString(format, CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public string ToString(IFormatProvider? formatProvider)
        {
            if (formatProvider == null)
            {
                return ToString();
            }

            return string.Format(formatProvider, "Minimum:{0} Maximum:{1}", Minimum.ToString(), Maximum.ToString());
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (format is null)
            {
                return ToString(formatProvider);
            }

            return string.Format(formatProvider, "Minimum:{0} Maximum:{1}", Minimum.ToString(format, formatProvider), Maximum.ToString(format, formatProvider));
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Minimum.GetHashCode() * 397) ^ Maximum.GetHashCode();
            }
        }

        /// <summary>
        /// Determines whether the specified <see cref="Vector4D"/> is equal to this instance.
        /// </summary>
        /// <param name="value">The <see cref="Vector4D"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="Vector4D"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(ref BoundingBox value)
        {
            return Minimum == value.Minimum && Maximum == value.Maximum;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Vector4D"/> is equal to this instance.
        /// </summary>
        /// <param name="value">The <see cref="Vector4D"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="Vector4D"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(BoundingBox value)
        {
            return Equals(ref value);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="value">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object? value)
        {
            if (value is null || (value is not BoundingBox strongValue))
            {
                return false;
            }

            return Equals(ref strongValue);
        }
    }

    //public class BoundingBox
    //{
    //    public Point3D Min { get; private set; }

    //    public Point3D Mid { get; private set; }

    //    public Point3D Max { get; private set; }

    //    private readonly List<Point3D> _minHistory;
    //    private readonly List<Point3D> _maxHistory;

    //    public BoundingBox(Point3D min, Point3D max)
    //    {
    //        Min = min;// ?? Point3D.Null;
    //        Max = max;// ?? Point3D.Null;

    //        _minHistory = new List<Point3D>();
    //        _maxHistory = new List<Point3D>();

    //        if (!Point3D.IsNaN(Min) && !Point3D.IsNaN(Max))
    //        {
    //            _minHistory.Add(Min);
    //            _maxHistory.Add(Max);

    //            var xMid = (Min.X + Max.X) * 0.5f;
    //            var yMid = (Min.Y + Max.Y) * 0.5f;
    //            var zMid = (Min.Z + Max.Z) * 0.5f;

    //            Mid = new Point3D(xMid, yMid, zMid);
    //        }
    //        else
    //        {
    //            Mid = Point3D.NaN;
    //        }
    //    }

    //    public BoundingBox(double minX, double minY, double minZ, double maxX, double maxY, double maxZ)
    //    {
    //        Min = new Point3D(minX, minY, minZ);
    //        Max = new Point3D(maxX, maxY, maxZ);

    //        var xMid = (Min.X + Max.X) * 0.5f;
    //        var yMid = (Min.Y + Max.Y) * 0.5f;
    //        var zMid = (Min.Z + Max.Z) * 0.5f;

    //        Mid = new Point3D(xMid, yMid, zMid);

    //        _minHistory = new List<Point3D>() { Min };
    //        _maxHistory = new List<Point3D>() { Max };
    //    }

    //    //public vtkPolyData GetVtkData()
    //    //{
    //    //    var Point3Ds = vtkPoint3Ds.New();

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Min.Y, Min.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Min.Y, Min.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Min.Y, Min.Z);
    //    //    Point3Ds.InsertNextPoint3D(Min.X, Max.Y, Min.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Min.Y, Min.Z);
    //    //    Point3Ds.InsertNextPoint3D(Min.X, Min.Y, Max.Z);

    //    //    Point3Ds.InsertNextPoint3D(Max.X, Min.Y, Min.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Max.Y, Min.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Max.Y, Min.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Max.Y, Min.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Min.Y, Max.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Max.Y, Max.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Min.Y, Max.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Min.Y, Max.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Min.Y, Max.Z);
    //    //    Point3Ds.InsertNextPoint3D(Min.X, Max.Y, Max.Z);

    //    //    Point3Ds.InsertNextPoint3D(Max.X, Min.Y, Max.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Max.Y, Max.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Max.Y, Max.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Max.Y, Max.Z);

    //    //    Point3Ds.InsertNextPoint3D(Min.X, Max.Y, Min.Z);
    //    //    Point3Ds.InsertNextPoint3D(Min.X, Max.Y, Max.Z);

    //    //    Point3Ds.InsertNextPoint3D(Max.X, Min.Y, Min.Z);
    //    //    Point3Ds.InsertNextPoint3D(Max.X, Min.Y, Max.Z);

    //    //    var lines = vtkCellArray.New();

    //    //    for (int i = 0; i < (int)Point3Ds.GetNumberOfPoint3Ds(); )
    //    //    {
    //    //        var line = vtkLine.New();
    //    //        line.GetPoint3DIds().SetNumberOfIds(2);

    //    //        line.GetPoint3DIds().SetId(0, i);
    //    //        line.GetPoint3DIds().SetId(1, i + 1);

    //    //        lines.InsertNextCell(line);

    //    //        i += 2;
    //    //    }

    //    //    var polyData = vtkPolyData.New();

    //    //    polyData.SetPoint3Ds(Point3Ds);
    //    //    polyData.SetLines(lines);

    //    //    return polyData;
    //    //}

    //    public static BoundingBox FromPoint3Ds(Point3D[] Point3Ds)
    //    {
    //        if (Point3Ds == null)
    //        {
    //            throw new ArgumentNullException("Point3Ds");
    //        }

    //        Point3D min = new Point3D(double.MaxValue);
    //        Point3D max = new Point3D(double.MinValue);

    //        for (int i = 0; i < Point3Ds.Length; ++i)
    //        {
    //            min = Point3D.Min(min, Point3Ds[i]);
    //            max = Point3D.Max(max, Point3Ds[i]);
    //        }

    //        return new BoundingBox(min, max);
    //    }

    //    #region Contains Methods
    //    public bool Contains(Point3D Point3D)
    //    {
    //        return (Point3D.X <= Max.X) &&
    //               (Point3D.Y <= Max.Y) &&
    //               (Point3D.Z <= Max.Z) &&
    //               (Point3D.X >= Min.X) &&
    //               (Point3D.Y >= Min.Y) &&
    //               (Point3D.Z >= Min.Z);
    //    }
    //    #endregion

    //    #region UpdateAdd Methods

    //    public BoundingBox UpdateAdd(Point3D Point3D)
    //    {
    //        bool addToMin = false;

    //        double minX = Min.X;
    //        double minY = Min.Y;
    //        double minZ = Min.Z;

    //        if (Point3D.X < Min.X)
    //        {
    //            minX = Point3D.X;
    //            addToMin = true;
    //        }

    //        if (Point3D.Y < Min.Y)
    //        {
    //            minY = Point3D.Y;
    //            addToMin = true;
    //        }

    //        if (Point3D.Z < Min.Z)
    //        {
    //            minZ = Point3D.Z;
    //            addToMin = true;
    //        }

    //        if (addToMin)
    //        {
    //            Min = new Point3D(minX, minY, minZ);

    //            _minHistory.Add(Min);
    //        }

    //        //////////////////////////////////////

    //        bool addToMax = false;

    //        double maxX = Max.X;
    //        double maxY = Max.Y;
    //        double maxZ = Max.Z;

    //        if (Point3D.X > Max.X)
    //        {
    //            maxX = Point3D.X;
    //            addToMax = true;
    //        }

    //        if (Point3D.Y > Max.Y)
    //        {
    //            maxY = Point3D.Y;
    //            addToMax = true;
    //        }

    //        if (Point3D.Z > Max.Z)
    //        {
    //            maxZ = Point3D.Z;
    //            addToMax = true;
    //        }

    //        if (addToMax)
    //        {
    //            Max = new Point3D(maxX, maxY, maxZ);

    //            _maxHistory.Add(Max);
    //        }

    //        if (addToMin || addToMax)
    //        {
    //            var xMid = (Min.X + Max.X) * 0.5f;
    //            var yMid = (Min.Y + Max.Y) * 0.5f;
    //            var zMid = (Min.Z + Max.Z) * 0.5f;

    //            Mid = new Point3D(xMid, yMid, zMid);
    //        }

    //        return this;
    //    }

    //    public BoundingBox UpdateRemove(Point3D Point3D)
    //    {
    //        bool updateMidPoint3D = false;

    //        if (Abs(Point3D.X - Min.X) < double.Epsilon || Abs(Point3D.Y - Min.Y) < double.Epsilon || Abs(Point3D.Z - Min.Z) < double.Epsilon)
    //        {
    //            Point3D lastPoint3D = _minHistory.LastOrDefault();

    //            if (Point3D == lastPoint3D)
    //            {
    //                _minHistory.Remove(lastPoint3D);

    //                Min = _minHistory.LastOrDefault();

    //                updateMidPoint3D = true;
    //            }
    //        }

    //        if (Abs(Point3D.X - Max.X) < double.Epsilon || Abs(Point3D.Y - Max.Y) < double.Epsilon || Abs(Point3D.Z - Max.Z) < double.Epsilon)
    //        {
    //            Point3D lastPoint3D = _maxHistory.LastOrDefault();

    //            if (Point3D == lastPoint3D)
    //            {
    //                _maxHistory.Remove(lastPoint3D);

    //                Max = _maxHistory.LastOrDefault();

    //                updateMidPoint3D = true;
    //            }
    //        }

    //        if (!updateMidPoint3D)
    //        {
    //            return this;
    //        }

    //        if (Min != null && Max != null)
    //        {
    //            var xMid = (Min.X + Max.X) * 0.5f;
    //            var yMid = (Min.Y + Max.Y) * 0.5f;
    //            var zMid = (Min.Z + Max.Z) * 0.5f;

    //            Mid = new Point3D(xMid, yMid, zMid);
    //        }

    //        return this;
    //    }
    //    #endregion

    //    public List<Tuple<Point3D, Point3D>> GetQuads()
    //    {
    //        //List<Tuple<Point3D, Point3D>> quads = new List<Tuple<Point3D, Point3D>>();

    //        //1
    //        var upperBackRightMax = new Point3D(Max);
    //        var upperBackRightMin = new Point3D(Mid);
    //        var upperBackRight = new Tuple<Point3D, Point3D>(upperBackRightMax, upperBackRightMin);
    //        //2
    //        var upperFrontRightMax = new Point3D(Max.X, Mid.Y, Max.Z);
    //        var upperFrontRightMin = new Point3D(Mid.X, Min.Y, Mid.Z);
    //        var upperFrontRight = new Tuple<Point3D, Point3D>(upperFrontRightMax, upperFrontRightMin);
    //        //3
    //        var upperFrontLeftMax = new Point3D(Mid.X, Mid.Y, Max.Z);
    //        var upperFrontLeftMin = new Point3D(Min.X, Min.Y, Mid.Z);
    //        var upperFrontLeft = new Tuple<Point3D, Point3D>(upperFrontLeftMax, upperFrontLeftMin);
    //        //4
    //        var upperBackLeftMax = new Point3D(Mid.X, Max.Y, Max.Z);
    //        var upperBackLeftMin = new Point3D(Min.X, Mid.Y, Mid.Z);
    //        var upperBackLeft = new Tuple<Point3D, Point3D>(upperBackLeftMax, upperBackLeftMin);
    //        //5
    //        var lowerBackRightMax = new Point3D(Max.X, Max.Y, Mid.Z);
    //        var lowerBackRightMin = new Point3D(Mid.X, Mid.Y, Min.Z);
    //        var lowerBackRight = new Tuple<Point3D, Point3D>(lowerBackRightMax, lowerBackRightMin);
    //        //6
    //        var lowerFrontRightMax = new Point3D(Max.X, Mid.Y, Mid.Z);
    //        var lowerFrontRightMin = new Point3D(Mid.X, Min.Y, Min.Z);
    //        var lowerFrontRight = new Tuple<Point3D, Point3D>(lowerFrontRightMax, lowerFrontRightMin);
    //        //7
    //        var lowerFrontLeftMax = new Point3D(Mid);
    //        var lowerFrontLeftMin = new Point3D(Min);
    //        var lowerFrontLeft = new Tuple<Point3D, Point3D>(lowerFrontLeftMax, lowerFrontLeftMin);
    //        //8
    //        var lowerBackLeftMax = new Point3D(Mid.X, Max.Y, Mid.Z);
    //        var lowerBackLeftMin = new Point3D(Min.X, Mid.Y, Min.Z);
    //        var lowerBackLeft = new Tuple<Point3D, Point3D>(lowerBackLeftMax, lowerBackLeftMin);

    //        return new List<Tuple<Point3D, Point3D>>() { upperBackRight, upperFrontRight, upperFrontLeft, upperBackLeft, lowerBackRight, lowerFrontRight, lowerBackLeft, lowerFrontLeft };
    //    }
    //}
}