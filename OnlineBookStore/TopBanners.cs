using System;
using System.Net;

namespace OnlineBookStore
{
    public class TopBanners
    {
        private string html;
        private string url="http://www.idefix.com/";
        private string[] link = new string[6];
        private string[] hrefs = new string[7];

        public string[] Link
        {
            get
            {
                return link;
            }

            set
            {
                link = value;
            }
        }
        
        public string[] Hrefs
        {
            get
            {
                return hrefs;
            }

            set
            {
                hrefs = value;
            }
        }
        private int flag = 0;

        public void BannerParser()
        {
            Uri url = new Uri(this.url);
            WebClient client = new WebClient();
            html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);
            var bannernode = document.DocumentNode.SelectNodes("//div[@class='item']//img[@src]");
            var hrefnode = document.DocumentNode.SelectNodes("//div[@class='item']//a[@href]");
            Hrefs[0] = "https://github.com/TeamBetaOgu";

            /// Event Fire
            //HtmlDownloadCompleted();


            foreach (var node in bannernode)
            {
                if (flag == 6)
                    break;
                link[flag] = node.Attributes["src"].Value;
                flag++;
            }


            flag = 0;
            foreach (var node in hrefnode)
            {
                if (flag == 6)
                    break;
                hrefs[flag + 1] = node.Attributes["href"].Value;
                flag++;
            }
        }
    }
}
