#if UNITY_EDITOR

using UnityEditor;

    public static class BrokerTemplateCreator
    {
        static string TEMPLATE_BASE_PATH =  @"Packages/com.partisanprogrammer.broker/Editor/Templates";
        const string ASSET_PATH = "Assets/Create/Templates/";

        [MenuItem(ASSET_PATH + "Message", priority = 30)]
        public static void CreateMessageMenuItem()
        {
            ScriptTemplateCreator.CreateScriptAssetFromTemplateFile(TEMPLATE_BASE_PATH, "MessageTemplate");
        }

        [MenuItem(ASSET_PATH + "Empty Message", priority = 30)]
        public static void CreateEmptyMessageMenuItem()
        {
            ScriptTemplateCreator.CreateScriptAssetFromTemplateFile(TEMPLATE_BASE_PATH, "NewEmptyMessage");
        }
    }

#endif