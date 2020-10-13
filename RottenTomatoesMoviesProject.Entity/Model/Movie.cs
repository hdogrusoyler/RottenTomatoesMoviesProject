using System;
using System.Collections.Generic;
using System.Text;

namespace RottenTomatoesMoviesProject.Entity.Model
{

    public class MoviesResponse
    {
        public int pagecount { get; set; }
        public int pagelimit { get; set; }
        public int page { get; set; }
        public int total { get; set; }
        public List<Movie> movies { get; set; }
        public Links links { get; set; }
        public string link_template { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }

    public class Movie
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string mpaa_rating { get; set; }
        public int runtime { get; set; }
        public string critics_consensus { get; set; }
        public Release_Dates release_dates { get; set; }
        public Ratings ratings { get; set; }
        public string synopsis { get; set; }
        public Posters posters { get; set; }
        public List<Abridged_Cast> abridged_cast { get; set; }
        public Links1 links { get; set; }
    }

    public class Release_Dates
    {
        public string theater { get; set; }
        public string dvd { get; set; }
    }

    public class Ratings
    {
        public string critics_rating { get; set; }
        public int critics_score { get; set; }
        public string audience_rating { get; set; }
        public int audience_score { get; set; }
    }

    public class Posters
    {
        public string thumbnail { get; set; }
        public string profile { get; set; }
        public string detailed { get; set; }
        public string original { get; set; }
    }

    public class Links1
    {
        public string self { get; set; }
        public string alternate { get; set; }
        public string cast { get; set; }
        public string reviews { get; set; }
        public string similar { get; set; }
    }

    public class Abridged_Cast
    {
        public string name { get; set; }
        public string id { get; set; }
        public List<string> characters { get; set; }
    }


    //public class MoviesResponse
    //{
    //    public int pagecount { get; set; }
    //    public int pagelimit { get; set; }
    //    public int page { get; set; }
    //    public int total { get; set; }
    //    public Movie[] movies { get; set; }
    //    public Links links { get; set; }
    //    public string link_template { get; set; }
    //}

    //public class Links
    //{
    //    public string self { get; set; }
    //    public string next { get; set; }
    //}

    //public class Movie
    //{
    //    public string id { get; set; }
    //    public string title { get; set; }
    //    public int year { get; set; }
    //    public string mpaa_rating { get; set; }
    //    public object runtime { get; set; }
    //    public Release_Dates release_dates { get; set; }
    //    public Ratings ratings { get; set; }
    //    public string synopsis { get; set; }
    //    public Posters posters { get; set; }
    //    public Abridged_Cast[] abridged_cast { get; set; }
    //    public Links1 links { get; set; }
    //    public string critics_consensus { get; set; }
    //}

    //public class Release_Dates
    //{
    //    public string theater { get; set; }
    //    public string dvd { get; set; }
    //}

    //public class Ratings
    //{
    //    public string critics_rating { get; set; }
    //    public int critics_score { get; set; }
    //    public object audience_score { get; set; }
    //    public string audience_rating { get; set; }
    //}

    //public class Posters
    //{
    //    public string thumbnail { get; set; }
    //    public string profile { get; set; }
    //    public string detailed { get; set; }
    //    public string original { get; set; }
    //}

    //public class Links1
    //{
    //    public string self { get; set; }
    //    public string alternate { get; set; }
    //    public string cast { get; set; }
    //    public string reviews { get; set; }
    //    public string similar { get; set; }
    //}

    //public class Abridged_Cast
    //{
    //    public string name { get; set; }
    //    public string id { get; set; }
    //    public string[] characters { get; set; }
    //}

    ////

    //public class Movie
    //{
    //    public bool isInTheaters { get; set; }
    //    public int adjustedScore { get; set; }
    //    public Ratingsummary ratingSummary { get; set; }
    //    public bool isPlaying { get; set; }
    //    public int id { get; set; }
    //    public string title { get; set; }
    //    public string vanity { get; set; }
    //    public string synopsis { get; set; }
    //    public Casts casts { get; set; }
    //    public bool isOnDVD { get; set; }
    //    public int year { get; set; }
    //    public Maintrailer mainTrailer { get; set; }
    //    public string trackingType { get; set; }
    //    public Genreset[] genreSet { get; set; }
    //    public bool isUpcoming { get; set; }
    //    public Reviews reviews { get; set; }
    //    public string status { get; set; }
    //    public string mpaaRating { get; set; }
    //    public Purchaseoptions purchaseOptions { get; set; }
    //    public Links1 links { get; set; }
    //    public Videoclips videoClips { get; set; }
    //    public string runningTimeStr { get; set; }
    //    public int runningTime { get; set; }
    //    public string url { get; set; }
    //    public Photos photos { get; set; }
    //    public bool isOnOpening { get; set; }
    //    public bool isLimited { get; set; }
    //    public Posters posters { get; set; }
    //    public Ratings ratings { get; set; }
    //}

    //public class Ratingsummary
    //{
    //    public Topcritics topCritics { get; set; }
    //    public Audience audience { get; set; }
    //    public int allcount { get; set; }
    //    public int freshcount { get; set; }
    //    public int dvdcount { get; set; }
    //    public string consensus { get; set; }
    //    public Allcritics allCritics { get; set; }
    //    public int rottencount { get; set; }
    //    public int topcount { get; set; }
    //}

    //public class Topcritics
    //{
    //    public bool hasScore { get; set; }
    //    public bool hasReviews { get; set; }
    //}

    //public class Audience
    //{
    //    public int numTotal { get; set; }
    //    public float averageScore { get; set; }
    //    public string ratingType { get; set; }
    //    public int meterScore { get; set; }
    //}

    //public class Allcritics
    //{
    //    public bool hasScore { get; set; }
    //    public bool hasReviews { get; set; }
    //}

    //public class Casts
    //{
    //    public object[] creators { get; set; }
    //    public Castitem[] castItems { get; set; }
    //    public Screenwriter[] screenwriters { get; set; }
    //    public Director[] directors { get; set; }
    //    public Producer[] producers { get; set; }
    //}

    //public class Castitem
    //{
    //    public Person person { get; set; }
    //    public Character[] characters { get; set; }
    //}

    //public class Person
    //{
    //    public string name { get; set; }
    //    public string thumbnailImg { get; set; }
    //    public string url { get; set; }
    //}

    //public class Character
    //{
    //    public string name { get; set; }
    //}

    //public class Screenwriter
    //{
    //    public string name { get; set; }
    //    public string thumbnailImg { get; set; }
    //    public string url { get; set; }
    //}

    //public class Director
    //{
    //    public string name { get; set; }
    //    public string thumbnailImg { get; set; }
    //    public string url { get; set; }
    //}

    //public class Producer
    //{
    //    public string name { get; set; }
    //    public string thumbnailImg { get; set; }
    //    public string url { get; set; }
    //}

    //public class Maintrailer
    //{
    //}

    //public class Reviews
    //{
    //    public int total { get; set; }
    //    public object[] reviews { get; set; }
    //    public Links links { get; set; }
    //}

    //public class Links
    //{
    //    public string alternate { get; set; }
    //    public string self { get; set; }
    //    public string prev { get; set; }
    //}

    //public class Purchaseoptions
    //{
    //}

    //public class Links1
    //{
    //    public string alternate { get; set; }
    //}

    //public class Videoclips
    //{
    //    public object[] videoClips { get; set; }
    //    public int size { get; set; }
    //}

    //public class Photos
    //{
    //    public object[] photos { get; set; }
    //    public int length { get; set; }
    //}

    //public class Posters
    //{
    //    public string thumbnail { get; set; }
    //    public string detailed { get; set; }
    //    public string original { get; set; }
    //    public string profile { get; set; }
    //}

    //public class Ratings
    //{
    //    public int critics_score { get; set; }
    //    public int audience_score { get; set; }
    //}

    //public class Genreset
    //{
    //    public int id { get; set; }
    //    public string displayName { get; set; }
    //}

}
