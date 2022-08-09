#if UNITY_EDITOR
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public class WebglPreBuildProcessing : IPreprocessBuildWithReport
{
    public int callbackOrder => 1;
    public void OnPreprocessBuild(BuildReport report)
    {
        System.Environment.SetEnvironmentVariable("EMSDK_PYTHON", "/Library/Frameworks/Python.framework/Versions/3.9/bin/python3.9");
    }
}
#endif