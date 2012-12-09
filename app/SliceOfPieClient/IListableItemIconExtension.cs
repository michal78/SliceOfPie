﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace SliceOfPie {
    /// <summary>
    /// This is a factory for standard icons in the SliceOfPie user interface.
    /// </summary>
    public static class IListableItemIconExtension {

        private static BitmapImage
            projectIcon = createBitmapImage("project-icon"),
            folderIcon = createBitmapImage("folder-icon"),
            documentIcon = createBitmapImage("document-icon"),
            documentConflictIcon = createBitmapImage("document-icon-conflict");

        /// <summary>
        /// Returns the icon for this IListabeItem
        /// </summary>
        /// <param name="?">The IListableItem this method is invoked on.</am>
        /// <returns></returns>
        public static BitmapImage GetIcon(this IListableItem item) {
            if (item is Project) {
                return projectIcon;
            }
            else if (item is Folder) {
                return folderIcon;
            }
            else {
                return (item as Document).IsMerged? documentConflictIcon : documentIcon;
            }
        }

        /// <summary>
        /// This helper method returns a BitmapImage based on a filename.
        /// Note that this method only works with .bmp files.
        /// </summary>
        /// <param name="iconFileName">The name of the file without file extension.</am>
        /// <returns>A BitmapImage version of the icon</returns>
        private static BitmapImage createBitmapImage(string iconFileName) {
            BitmapImage icon = new BitmapImage();
            icon.BeginInit();
            icon.UriSource = new Uri("pack://application:,,,/Icons/" + iconFileName + ".png");
            icon.EndInit();
            return icon;
        }
    }
}
