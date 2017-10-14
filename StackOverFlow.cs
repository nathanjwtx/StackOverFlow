using System;
using System.Net.Mail;

namespace StackOverFlow
{
    class StackOverFlow
    {
        private string _title;
        private string _postBody;
        private DateTime _created;
        private int _score;

        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        public string PostBody
        {
            get => _postBody;
            set => _postBody = value;
        }

        public DateTime Created
        {
            get => _created;
        }

        public int Score => _score;

        public StackOverFlow()
        {
            this._score = 0;
            this._created = DateTime.Now;
        }

        public int UpdateScore(string upDown)
        {
            if (upDown == "u")
            {
                this._score += 1;
            }
            if (upDown == "d")
            {
                this._score -= 1;
            }
            return _score;
        }
    }
}