using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


const string struct_dir = @"D:\TFS_Sources\EngineeringTools\Utilities\Vulkan\Vulkan\Structs";



string array_template = @"        \[NativeTypeName\(""uint32_t""\)\](\n|\s*)public uint ([a-zA-Z0-9]+)Count;\n
        \[NativeTypeName\(""const ([a - zA - Z0 - 9]+) \*""\)\]
        public ([a-zA-Z0-9]+)\* P([a-zA-Z0-9]+)s;";

Regex array_template_regex = new Regex(array_template, RegexOptions.Compiled);

//Func<string, string, string> property_template = (string property, string type) => $@"
//public {type}[] {property}s
//{{
//    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
//    get
//    {{
//        return NativeIntExtensions.ToManagedArray({property}Count, P{property}s);
//        return narray;
//    }}
//    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
//    set
//    {{
//        P{property}s = NativeIntExtensions.ToPointer(value, out {property}Count);
//    }}
//}}
//";

string property_template = @"        [NativeTypeName(""uint32_t"")]
        public uint $2Count;

        [NativeTypeName(""const $3 *"")]
        public $4* P$5s;

        public $4[] $2s
        {{
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {{
                return NativeIntExtensions.ToManagedArray($2Count, P$2s);    
            }}
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {{
                P$2s = NativeIntExtensions.ToPointer(value, out $2Count);
            }}
        }}";


string[] fileEntries = Directory.GetFiles(struct_dir).Where(f=>f.Contains("VkWriteDescriptorSetAccelerationStructureKHR")).ToArray();

string file_contents;



for (int i = 0; i < fileEntries.Length;++i)
{
    Console.WriteLine(fileEntries[i]);

    file_contents = File.ReadAllText(fileEntries[i]);

    file_contents = Regex.Replace(file_contents, array_template, property_template);
    
    File.WriteAllText(fileEntries[i], file_contents);
}


