using System;
using System.Collections.Generic;
using System.Text;

namespace RottenTomatoesMoviesProject.Entity.Model
{

    public class MovieDetail
    {
        public string studio { get; set; }
        public bool isInTheaters { get; set; }
        public float adjustedScore { get; set; }
        public Ratingsummary ratingSummary { get; set; }
        public bool isPlaying { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string vanity { get; set; }
        public string officialUrl { get; set; }
        public string advisory { get; set; }
        public string synopsis { get; set; }
        public Casts casts { get; set; }
        public Maintrailer mainTrailer { get; set; }
        public bool isOnDVD { get; set; }
        public int year { get; set; }
        public string trackingType { get; set; }
        public Genreset[] genreSet { get; set; }
        public bool isUpcoming { get; set; }
        public Reviews reviews { get; set; }
        public string status { get; set; }
        public string mpaaRating { get; set; }
        public Purchaseoptions purchaseOptions { get; set; }
        public Links2 links { get; set; }
        public string boxoffice { get; set; }
        public Videoclips videoClips { get; set; }
        public int runningTime { get; set; }
        public string runningTimeStr { get; set; }
        public string url { get; set; }
        public Photos photos { get; set; }
        public bool isOnOpening { get; set; }
        public bool isLimited { get; set; }
        public Posters posters { get; set; }
        public Ratings ratings { get; set; }
    }

    public class Ratingsummary
    {
        public Topcritics topCritics { get; set; }
        public Audience audience { get; set; }
        public int allcount { get; set; }
        public int freshcount { get; set; }
        public int dvdcount { get; set; }
        public string consensus { get; set; }
        public Allcritics allCritics { get; set; }
        public int rottencount { get; set; }
        public int topcount { get; set; }
    }

    public class Topcritics
    {
        public float averageRating { get; set; }
        public int meterValue { get; set; }
        public int numReviews { get; set; }
        public string meterClass { get; set; }
        public int numRotten { get; set; }
        public bool hasScore { get; set; }
        public bool hasReviews { get; set; }
        public int numFresh { get; set; }
    }

    public class Audience
    {
        public int numTotal { get; set; }
        public float averageScore { get; set; }
        public string ratingType { get; set; }
        public int meterScore { get; set; }
    }

    public class Allcritics
    {
        public float averageRating { get; set; }
        public int meterValue { get; set; }
        public int numReviews { get; set; }
        public string meterClass { get; set; }
        public int numRotten { get; set; }
        public bool hasScore { get; set; }
        public bool hasReviews { get; set; }
        public int numFresh { get; set; }
    }

    public class Casts
    {
        public object[] creators { get; set; }
        public Castitem[] castItems { get; set; }
        public Screenwriter[] screenwriters { get; set; }
        public Director[] directors { get; set; }
        public Producer[] producers { get; set; }
    }

    public class Castitem
    {
        public Person person { get; set; }
        public Character[] characters { get; set; }
    }

    public class Person
    {
        public string name { get; set; }
        public string thumbnailImg { get; set; }
        public string url { get; set; }
    }

    public class Character
    {
        public string name { get; set; }
    }

    public class Screenwriter
    {
        public string name { get; set; }
        public string thumbnailImg { get; set; }
        public string url { get; set; }
    }

    public class Director
    {
        public string name { get; set; }
        public string thumbnailImg { get; set; }
        public string url { get; set; }
    }

    public class Producer
    {
        public string name { get; set; }
        public string thumbnailImg { get; set; }
        public string url { get; set; }
    }

    public class Maintrailer
    {
        public int id { get; set; }
        public string thumbUrl { get; set; }
        public string mp4Url { get; set; }
        public string hlsUrl { get; set; }
    }

    public class Reviews
    {
        public int total { get; set; }
        public Review[] reviews { get; set; }
        public Links links { get; set; }
    }

    //public class Links
    //{
    //    public string alternate { get; set; }
    //    public string next { get; set; }
    //    public string self { get; set; }
    //    public string prev { get; set; }
    //}

    public class Review
    {
        public int id { get; set; }
        public long creationDate { get; set; }
        public bool isRotten { get; set; }
        public string quote { get; set; }
        public Links1 links { get; set; }
        public string freshness { get; set; }
        public bool isTop { get; set; }
        public string url { get; set; }
        public bool isFresh { get; set; }
        public Critic critic { get; set; }
        public Publication publication { get; set; }
        public string original_score { get; set; }
    }

    public class Critic
    {
        public int id { get; set; }
        public string name { get; set; }
        public string thumbnailImage { get; set; }
        public string url { get; set; }
    }

    public class Publication
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Purchaseoptions
    {
        public Itunes iTunes { get; set; }
        public Flixster flixster { get; set; }
        public Netflix netflix { get; set; }
        public Amazon amazon { get; set; }
    }

    public class Itunes
    {
        public string price { get; set; }
        public string url { get; set; }
    }

    public class Flixster
    {
        public string movieId { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Netflix
    {
        public string streamingId { get; set; }
    }

    public class Amazon
    {
        public bool isPrime { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Links2
    {
        public string alternate { get; set; }
    }

    public class Videoclips
    {
        public Maintrailer1 mainTrailer { get; set; }
        public Videoclip[] videoClips { get; set; }
        public int size { get; set; }
    }

    public class Maintrailer1
    {
        public int id { get; set; }
        public string title { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }
        public string thumbUrl { get; set; }
        public string mp4Url { get; set; }
        public string hlsUrl { get; set; }
    }

    public class Videoclip
    {
        public int id { get; set; }
        public string title { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }
        public string thumbUrl { get; set; }
        public string mp4Url { get; set; }
        public string hlsUrl { get; set; }
    }

    public class Photos
    {
        public Photo[] photos { get; set; }
        public int length { get; set; }
    }

    public class Photo
    {
        public string id { get; set; }
        public string photoType { get; set; }
        public int index { get; set; }
        public int imageId { get; set; }
        public string thumbnail { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string submittedDate { get; set; }
        public string submittedBy { get; set; }
        public string url { get; set; }
    }

    public class Genreset
    {
        public int id { get; set; }
        public string displayName { get; set; }
    }
}
