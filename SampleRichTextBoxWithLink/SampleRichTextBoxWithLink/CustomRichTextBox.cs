using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace RichTextBoxWithLink
{
    public class CustomRichTextBox : RichTextBox
    {

        #region CustomText Dependency Property

        public static readonly DependencyProperty CustomTextProperty = DependencyProperty.Register("CustomText", typeof(string), typeof(CustomRichTextBox),
       new PropertyMetadata(string.Empty, CustomTextChangedCallback), CustomTextValidateCallback);

        private static void CustomTextChangedCallback(
            DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            (obj as CustomRichTextBox).Document = GetCustomDocument(e.NewValue as string);
        }

        private static bool CustomTextValidateCallback(object value)
        {
            return value != null;
        }

        public string CustomText
        {
            get
            {
                return (string)GetValue(CustomTextProperty);
            }
            set
            {
                SetValue(CustomTextProperty, value);
            }
        } 

        #endregion


        public CustomRichTextBox()
        {

        }

        private static  FlowDocument GetCustomDocument(string Text)
        {
            FlowDocument document = new FlowDocument();
            Paragraph para = new Paragraph();
            para.Margin = new Thickness(0); // remove indent between paragraphs
            foreach (string word in Text.Split(' ').ToList())
            {
                //This condition could be replaced by the Regex
                if(word.StartsWith("*"))
                {
                    string linkName = word.Substring(1, word.Length - 1);
                    //linkURL can be changed based on some condition.
                    string linkURL = "https://www.google.com";

                    Hyperlink link = new Hyperlink();
                    link.IsEnabled = true;
                    link.Inlines.Add(linkName);
                    link.NavigateUri = new Uri(linkURL);
                    link.RequestNavigate += (sender, args) => Process.Start(args.Uri.ToString());
                    para.Inlines.Add(link);
                }
                else
                {
                    para.Inlines.Add(word);
                }
                para.Inlines.Add(" ");
            }
            document.Blocks.Add(para);
            return document;
        }

    }
}
