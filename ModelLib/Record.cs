using System;

namespace ModelLib
{
    public class Record
    {
        private string _title;
        private string _artist;
        private int _duration;
        private int _publicationYear;

        public Record(string title, string artist, int duration, int publicationYear)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public string Title { get => _title; set => _title = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public int Duration { get => _duration; set => _duration = value; }
        public int PublicationYear { get => _publicationYear; set => _publicationYear = value; }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Artist)}: {Artist}, {nameof(Duration)}: {Duration}, {nameof(PublicationYear)}: {PublicationYear}";
        }
    }
}
