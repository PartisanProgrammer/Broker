#if UNITY_EDITOR

using System.IO;
using UnityEditor;

    public static class BrokerTemplateCreator
    {
        static string TEMPLATE_BASE_PATH =  @"Packages/com.partisanprogrammer.broker/Editor/Templates/";
        const string ASSET_PATH = "Assets/Create/Templates/";

        [MenuItem(ASSET_PATH + "Message", priority = 30)]
        public static void CreateMessageMenuItem()
        {
            var filename = "MessageTemplate.txt";
            CreateScriptAssetFromTemplateFile(filename);
        }

        [MenuItem(ASSET_PATH + "Empty Message", priority = 30)]
        public static void CreateEmptyMessageMenuItem()
        {
            var filename = "EmptyMessageTemplate.txt";
            CreateScriptAssetFromTemplateFile(filename);
        }
        
        public static void CreateScriptAssetFromTemplateFile(string templateName)
        {
            var createdFileName = templateName.Insert(0, "New")
                .Replace("Template.txt", ".cs");
            var fullTemplateFilePath = Path.Join (TEMPLATE_BASE_PATH, templateName);
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(fullTemplateFilePath, createdFileName);
        }
    }

#endif