using System.Collections.Generic;

public class DownLoadInfo
{
    /// <summary>
    /// 下载的链接
    /// </summary>
    public IList<string> DownLoadUrl { get; set; }

    /// <summary>
    /// 下载的路径
    /// </summary>
    public string DownLoadPath { get; set; }
}