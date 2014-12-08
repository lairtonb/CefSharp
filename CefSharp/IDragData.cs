﻿using System.Collections.Generic;

namespace CefSharp
{
    public interface IDragData
    {
        /// <summary>
        /// Returns true if this object is read-only.
        /// </summary>
        bool IsReadOnly { get; }

        /// <summary>
        /// Return the name of the file being dragged out of the browser window.
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// Retrieve the list of file names that are being dragged into the browser window
        /// </summary>
        IList<string> FileNames { get; }

        /// <summary>
        /// Return the base URL that the fragment came from. This value is used for resolving relative URLs and may be empty. 
        /// </summary>
        string FragmentBaseUrl { get; set; }

        /// <summary>
        /// Return the text/html fragment that is being dragged. 
        /// </summary>
        string FragmentHtml { get; set; }

        /// <summary>
        /// Return the plain text fragment that is being dragged.
        /// </summary>
        string FragmentText { get; set; }

        /// <summary>
        /// Return the metadata, if any, associated with the link being dragged. 
        /// </summary>
        string LinkMetaData { set; get; }

        /// <summary>
        /// Return the title associated with the link being dragged.
        /// </summary>
        string LinkTitle { set; get; }

        /// <summary>
        /// Return the link URL that is being dragged. 
        /// </summary>
        string LinkUrl { set; get; }

        /// <summary>
        /// Returns true if the drag data is a file.
        /// </summary>
        bool IsFile { get; set; }

        /// <summary>
        /// Returns true if the drag data is a text or html fragment.
        /// </summary>
        bool IsFragment { get; set; }

        /// <summary>
        /// Returns true if the drag data is a link
        /// </summary>
        bool IsLink { get; set; }

        /// <summary>
        /// Add a file that is being dragged into the webview.
        /// </summary>
        /// <param name="path">File Path</param>
        /// <param name="displayName">Optional Display Name</param>
        void AddFile(string path, string displayName = null);
    }
}