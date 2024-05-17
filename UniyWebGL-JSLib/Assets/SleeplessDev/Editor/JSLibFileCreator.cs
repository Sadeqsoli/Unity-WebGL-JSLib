using System.IO;
using UnityEditor;

public class JSLibFileCreator
{
    [MenuItem("Assets/Create/JS Script-Template", priority = 80)]
    private static void CreateJSLibFile()
    {
        // Script template so that the file is not empty initially
        var asset =
            "mergeInto(LibraryManager.library,\n" +
            "{\n" +
                "\t// Your code here\n" +
            "});";
        // We take the path to the current open folder in the Project window
        string path = AssetDatabase.GetAssetPath(Selection.activeObject);
        if (path == "")
        {
            path = "Assets";
        }
        else if (Path.GetExtension(path) != "")
        {
            path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
        }
        // Creating a .jslib file with a template
        ProjectWindowUtil.CreateAssetWithContent(AssetDatabase.GenerateUniqueAssetPath(path + "/JSScript.jslib"), asset);
        // Saving Assets
        AssetDatabase.SaveAssets();
    }

    [MenuItem("Assets/Create/JS Script-Without Template", priority = 80)]
    private static void CreateJSLibFileTempLess()
    {
        // Script template so that the file is not empty initially
        var asset = "";
        // We take the path to the current open folder in the Project window
        string path = AssetDatabase.GetAssetPath(Selection.activeObject);
        if (path == "")
        {
            path = "Assets";
        }
        else if (Path.GetExtension(path) != "")
        {
            path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
        }
        // Creating a .jslib file with a template
        ProjectWindowUtil.CreateAssetWithContent(AssetDatabase.GenerateUniqueAssetPath(path + "/JSScript.jslib"), asset);
        // Saving Assets
        AssetDatabase.SaveAssets();
    }
}
