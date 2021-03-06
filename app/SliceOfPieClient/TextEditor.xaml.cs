﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SliceOfPie;

namespace SliceOfPie.Client {
    /// <summary>
    /// Interaction logic for the Text Editor User Control.
    /// This UserControl shows a Text Editor based on its Document property.
    /// </summary>
    public partial class TextEditor : UserControl {
        private Document _document; //backing field
        private Controller controller;

        /// <summary>
        /// This is the Document currently shown in the Text Editor.
        /// Changing this will change what is shown.
        /// </summary>
        public Document Document {
            get { return _document; }
            set {
                //update ui to the new document
                _document = value;
                _textField.Text = _document.CurrentRevision;
            }
        }

        /// <summary>
        /// This is the text in shown in the editor
        /// </summary>
        public string Text {
            get { return _textField.Text; }
            set { _textField.Text = value; }
        }

        /// <summary>
        /// The position of the caret in the text.
        /// </summary>
        public int CaretIndex {
            get { return _textField.CaretIndex; }
            set { _textField.CaretIndex = value; }
        }
                
        /// <summary>
        /// Creates a Text Editor with the functionality to show and edit Documents
        /// For content to be shown, the Document property must be set.
        /// </summary>
        public TextEditor() {
            InitializeComponent();
            controller = Controller.Instance;
        }

        /// <summary>
        /// This method makes the field of text focused.
        /// </summary>
        public void FocusText() {
            _textField.Focus();
        }
    }
}
