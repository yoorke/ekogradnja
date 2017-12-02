using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ekogradnjaBE
{
    public class Page
    {
        private int _idPage;
        private string _title;
        private string _description;
        private string _keywords;
        private string _content;
        private int _idPageType;
        private string _url;

        public int IdPage
        {
            get { return _idPage; }
            set { _idPage = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Keywords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public int IdPageType
        {
            get { return _idPageType; }
            set { _idPageType = value; }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
