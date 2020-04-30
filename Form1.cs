using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;
using Codeplex.Data;

namespace ISBNsearchTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string test;

        private void Searchbt_Click(object sender, EventArgs e)
        {

            String url = "https://www.googleapis.com/books/v1/volumes?q=ISBN:" + ISBN.Text;
            WebRequest request = WebRequest.Create(url);
            Stream response_stream = request.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(response_stream);
            string ReadInfo = reader.ReadToEnd();

            //debug用
            //StatusBox.Text = ReadInfo;
            //           string ReadInfo = @"{
            //""kind"": ""books#volumes"",
            //""totalItems"": 1,
            //""items"": [
            //	{
            //		""kind"": ""books#volume"",
            //		""id"": ""H7XQrQEACAAJ"",
            //		""etag"": ""iChwIDOVLeE"",
            //		""selfLink"": ""https://www.googleapis.com/books/v1/volumes/H7XQrQEACAAJ"",
            //           ""volumeInfo"": {
            //               ""title"": ""キタミ式イラストIT塾基本情報技術者"",
            //			""subtitle"": ""test"",
            //               ""authors"": [
            //				""きたみりゅうじ""
            //			],
            //           ""publishedDate"": ""2015 - 01 - 20"",
            //           ""description"": ""目で見てわかるから理解できる。だから合格できる!「このように出題されています」各節末に過去試験問題と解説を収録。新出題方式もキタミ式で大丈夫。"",
            //           ""industryIdentifiers"": [
            //           		{
            //           			""type"": ""ISBN_10"",
            //           			""identifier"": ""4774170801""

            //                    },
            //           	    {
            //           			""type"": ""ISBN_13"",
            //           			""identifier"": ""9784774170800""
            //           		}
            //           	],
            //           ""readingModes"": {
            //               ""text"": false,
            //               ""image"": false
            //               },
            //           ""pageCount"": 655,
            //           ""printType"": ""BOOK"",
            //           ""maturityRating"": ""NOT_MATURE"",
            //           ""allowAnonLogging"": false,
            //           ""contentVersion"": ""preview - 1.0.0"",
            //           ""imageLinks"": {
            //               ""smallThumbnail"": ""http://books.google.com/books/content?id=H7XQrQEACAAJ&printsec=frontcover&img=1&zoom=5&source=gbs_api"",
            //               ""thumbnail"": ""http://books.google.com/books/content?id=H7XQrQEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api""
            //               },
            //           ""language"": ""ja"",
            //           ""previewLink"": ""http://books.google.co.jp/books?id=H7XQrQEACAAJ&dq=ISBN:9784774170800&hl=&cd=1&source=gbs_api"",
            //           ""infoLink"": ""http://books.google.co.jp/books?id=H7XQrQEACAAJ&dq=ISBN:9784774170800&hl=&source=gbs_api"",
            //           ""canonicalVolumeLink"": ""https://books.google.com/books/about/%E3%82%AD%E3%82%BF%E3%83%9F%E5%BC%8F%E3%82%A4%E3%83%A9%E3%82%B9%E3%83%88IT%E5%A1%BE%E5%9F%BA%E6%9C%AC%E6%83%85.html?hl=&id=H7XQrQEACAAJ""
            //               },
            //          ""saleInfo"": {
            //               ""country"": ""JP"",
            //           	""saleability"": ""NOT_FOR_SALE"",
            //           	""isEbook"": false
            //           	},
            //          ""accessInfo"": {
            //               ""country"": ""JP"",
            //               ""viewability"": ""NO_PAGES"",
            //               ""embeddable"": false,
            //               ""publicDomain"": false,
            //               ""textToSpeechPermission"": ""ALLOWED"",
            //               ""epub"": {
            //                   ""isAvailable"": false
            //                   },
            //               ""pdf"": {
            //                   ""isAvailable"": false
            //           	    },
            //               ""webReaderLink"": ""http://play.google.com/books/reader?id=H7XQrQEACAAJ&hl=&printsec=frontcover&source=gbs_api"",
            //               ""accessViewStatus"": ""NONE"",
            //               ""quoteSharingAllowed"": false
            //           	    },
            //           ""searchInfo"": {
            //               ""textSnippet"": ""目で見てわかるから理解できる。だから合格できる!「このように出題されています」各節末に過去試験問題と解説を収録。新出題方式もキタミ式で大丈夫。""
            //                       }
            //           		}
            //           	]
            //           }";

            //うまくいかない

            var booksByJson = JsonConvert.DeserializeObject<GoogleBookAPI>(ReadInfo);

            StatusBox.Text = booksByJson.items[0].VolumeInfo.title;
            

            //力技
            //var obj_from_json = JObject.Parse(ReadInfo);
            //string test = obj_from_json.GetValue("items").ToString();
            //int index = test.Replace("}\r\n  }", "散").IndexOf('散');
            //test = test.Substring(1, index+5);
            //var obj_from_json2 = JObject.Parse(test);
            //string volumeInfo = obj_from_json2.GetValue("volumeInfo").ToString();
            //var obj_from_json3 = JObject.Parse(volumeInfo);
            //string title = obj_from_json3.GetValue("title").ToString();
            //string authors = obj_from_json3.GetValue("authors").ToString();
            //authors = authors.Replace("[\r\n  \"","").Replace("\"\r\n]","");
            //MessageBox.Show(authors);


            /* 配列で計算する方法 */  
            //int[] index = new int[3];
            //string[] result = ReadInfo.Split(',');
            //for (int i = 0; i < 20; i++)
            //{
            //    if (result[i].Contains("\"title\":"))
            //        index[0] = i;
            //    else if (result[i].Contains("\"authors\":"))
            //        index[1] = i;
            //    else if (result[i].Contains("\"publishedDate\":"))
            //        index[2] = i;
            //    if (index[0] * index[1] * index[2] != 0)
            //        break;
            //}

            //string title = result[index[0]].Substring(33).Replace("\"", "").Trim();
            //string author = result[index[1]].Substring(21).Replace("\"", "").Replace("]", "").Trim();
            //string PublishDate = result[index[2]].Substring(21).Replace("\"", "").Trim();

            //StatusBox.Text = "title = " + title + "\r\n" ;
            //StatusBox.Text += "author = " + author + "\r\n";
            //StatusBox.Text += "PublishDate = " + PublishDate + "\r\n";


        }
    }

    #region JSON Data定義
    class GoogleBookAPI
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public item[] items { get; set; }
    }
    class item
    {
        public string kind { get; set; }
        public string iD { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public volumeInfos VolumeInfo { get; set; }
        public saleInfos SaleInfo { get; set; }
        public accessInfos AccessInfo { get; set; }
        public searchInfos SearchInfo { get; set; }
    }
    class volumeInfos
    {
        public string title { get; set; }
        public string subtitle { get; set; }
        public string[] authors { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        public industryIdentifier[] IndustryIdentifiers { get; set; }
        public ReadingMode ReadingModes { get; set; }
        public int PageCount { get; set; }
        public string PrintType { get; set; }
        public string MaturityRating { get; set; }
        public bool AllowAnonLogging { get; set; }
        public string ContentVersion { get; set; }
        public imageLink imageLinks { get; set; }
        public string Language { get; set; }
        public string PreviewLink { get; set; }
        public string InfoLink { get; set; }
        public string CanonicalVolumeLink { get; set; }
    }
    class industryIdentifier
    {
        public string Type { get; set; }
        public string Identifier { get; set; }
    }

    class ReadingMode
    {
        public bool Text { get; set; }
        public bool Image { get; set; }
    }
    class imageLink
    {
        public string smallThumbnail { get; set; }

        public string thumbnail { get; set; }
    }
    class saleInfos
    {
        public string Country { get; set; }
        public string Saleability { get; set; }
        public bool IsEbook { get; set; }
    }
    class accessInfos
    {
        public string Country { get; set; }
        public string Viewability { get; set; }
        public bool Embeddable { get; set; }
        public bool PublicDomain { get; set; }
        public string TextToSpeechPermission { get; set; }
        public epubs Epub { get; set; }
        public pdfs Pdf { get; set; }
        public string WebReaderLink { get; set; }
        public string AccessViewStatus { get; set; }
        public bool QuoteSharingAllowed { get; set; }
    }
    class epubs
    {
        public bool IsAvailable { get; set; }
    }
    class pdfs
    {
        public bool IsAvailable { get; set; }
    }
    class searchInfos
    {
        public string TextSnippet { get; set; }
    }

    #endregion


    //test
    class Book {
        public string Ids { get; set; }
        public string Name { get; set; }
        public Asins Asin { get; set; }
    }

    class Asins
    {
        public string Id { get; set; }
        public string Name
        {
            get; set;
        }
    }
}
