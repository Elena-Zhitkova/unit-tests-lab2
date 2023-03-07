using System.Net.Http;
using System.Text;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //applications list
        [Test]
        public void Test1()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44348/api/Applications").Result;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        //application created
        [Test]
        public void Test2()
        {
            var httpClient = new HttpClient();
            var content = new StringContent(
                "{\"name\": \"1\",\"author\": \"1\",\"email\": \"dhj@fhdj.com\",\"assignee\": \"ћельш ћаксим ћаксимович\",\"status\": \"ќбработать\",\"criticReviewFile\": \"\",\"redactorReviewFile\": \"\",\"keyWords\": \"1\",\"articleFile\": \"C:\\\\Users\\\\qweqw\\\\AppData\\\\Local\\\\Temp\\\\15449-“екст статьи-31541-1-10-20221124.pdf\",\"gradeAntiplagiat\": \"gfhkdlagh\",\"authorUserId\": \"\",\"annotation\": \"1\"\r\n    }"
                , Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44348/api/Applications", content).Result;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.Created);
        }

        //application view
        [Test]
        public void Test3()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44348/api/Applications/25").Result;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        //article view
        [Test]
        public void Test4()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44348/api/Articles/5").Result;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        //article created
        [Test]
        public void Test5()
        {
            var httpClient = new HttpClient();
            var content = new StringContent(
                "{\r\n    \"magazineId\": 4,\r\n    \"articleName\": \"ќсновани€ дорожных одежд из вторичных материалов\",\r\n    \"articleAuthor\": \"јльбер јльберт јльбертович\",\r\n    \"articlePDF\": \"C:\\\\Users\\\\qweqw\\\\AppData\\\\Local\\\\Temp\\\\2618-4625-1-SM.pdf\",\r\n    \"keywords\": \"основание, асфальтогранул€т, цементогранул€т, прочность, температура, разрушающа€ нагрузка, предел прочности, сжатие, отработанна€ формовочна€ смесь, выравнивающий слой, цемент, раст€жение при изгибе\",\r\n    \"annotation\": \"ƒорожные основани€ Ц главные несущие слои дорожной одежды, назначение которых Ц воспри€тие нагрузки от автомобилей и распределение ее на грунт земл€ного полотна.  онструкци€ основани€ определ€етс€ по расчету в зависимости от планируемой транспортной нагрузки и интенсивности движени€ и состоит, как правило, из нескольких слоев. ѕричем у капитальных покрытий верхний слой основани€ устраиваетс€ из материалов, укрепленных в€жущими. \",\r\n    \"gradeQuoting\": 0,\r\n    \"gradeDowload\": 0,\r\n    \"gradeViews\": 0\r\n}"
                , Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44348/api/Articles", content).Result;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.Created);
        }

        //article list
        [Test]
        public void Test6()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44348/api/Articles").Result;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }

        //archives list
        [Test]
        public void Test7()
        {
            var httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44348/api/Archives").Result;
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }
    }
}