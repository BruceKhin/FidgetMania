using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TricksUrlController : MonoBehaviour
{
    string[] urls = new string[]
        {
            "https://r1---sn-4g5e6ney.googlevideo.com/videoplayback?clen=3119055&sparams=clen,dur,ei,expire,gir,id,initcwndbps,ip,ipbits,itag,lmt,mime,mm,mn,ms,mv,pl,ratebypass,requiressl,source,upn&ipbits=0&lmt=1494150227655691&source=youtube&dur=36.060&requiressl=yes&mime=video%2Fmp4&gir=yes&signature=656DE6A8881D0F087474F510B9E50405C7069F20.72B0D2D60CB0C7988032CDFDDE2099F7AD62DE4D&key=cms1&itag=18&upn=Dy7kcDuybkk&expire=1494868043&ratebypass=yes&ei=64sZWei7FsTScf3Xo7AM&pl=24&ip=91.208.153.1&id=o-ALzy6Swafwwl5Y8-VY0Rrxpe-kZvpR5PS_sFtcfrwW4Q&cm2rm=sn-8xb5-qo3e7l,sn-3c2ree&req_id=78f7b4da60e6a3ee&redirect_counter=2&cms_redirect=yes&mm=34&mn=sn-4g5e6ney&ms=ltu&mt=1494846376&mv=m",
            "https://r3---sn-8xb5-qo3l.googlevideo.com/videoplayback?expire=1494868100&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpcm2cms%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&upn=uW4Obzx_Rkw&key=yt6&gir=yes&ipbits=0&mt=1494846439&mime=video%2Fmp4&initcwndbps=9351250&itag=18&ratebypass=yes&requiressl=yes&clen=4107761&signature=3A438A94360E1DF97EF30C99AC98F85E9400B553.88B0D6FD55FF9C638FEC7D412CE964109D659008&id=o-APqlkhWRfSRrOb-YZW-8nEcjnKyUZX2EuIeWCpsJX6BT&pcm2cms=yes&mn=sn-8xb5-qo3l&mm=31&pl=24&dur=44.489&lmt=1494151442468246&ip=91.208.153.1&ms=au&ei=JIwZWbfgDo2Lcp6ImYgC&mv=m&source=youtube",
            "https://r2---sn-8xb5-qo3l.googlevideo.com/videoplayback?clen=3854801&dur=52.523&ratebypass=yes&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&lmt=1494152652655575&ipbits=0&expire=1494868157&requiressl=yes&source=youtube&initcwndbps=9351250&ei=XYwZWaLrD4T5cPGZtKAN&ip=91.208.153.1&mm=31&mn=sn-8xb5-qo3l&itag=18&pl=24&gir=yes&signature=618492C45788829ED66908FC43B0B7B3D0DB702B.10FBB7CC7F2F7C84D3881C18EE32D7FEDA504AD0&id=o-AMQyOhhc5ZlM5TdbVQ158vfzMdne3NybCHiYlqyKh6Uq&mt=1494846439&mv=m&upn=6d3vj9lp3wE&ms=au&key=yt6&mime=video%2Fmp4",
            "https://r2---sn-8xb5-qo3l.googlevideo.com/videoplayback?ei=d4wZWbbhOYzacv2NqYAI&ms=au&mt=1494846502&mv=m&requiressl=yes&ratebypass=yes&gir=yes&clen=3558448&mn=sn-8xb5-qo3l&source=youtube&initcwndbps=15907500&id=o-AFgyf6BkjQtGPdimt2yESNtW0clviIQzu8OhbO6lj9Wq&mm=31&dur=41.424&expire=1494868184&ip=91.208.153.1&key=yt6&lmt=1494154555993371&upn=Kff32IDi3pI&signature=0A42B618B2B7EF797E479581A0395EF9347DBDF6.4247DA7C612AF0EA985F42E864942C92F967F466&ipbits=0&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&mime=video%2Fmp4&itag=18&pl=24",
            "https://r2---sn-8xb5-qo3l.googlevideo.com/videoplayback?expire=1494868205&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&key=yt6&mime=video%2Fmp4&dur=50.758&source=youtube&lmt=1494155304889935&ratebypass=yes&itag=18&requiressl=yes&upn=4zZJtT4OhtM&ipbits=0&ei=jYwZWZ6YGZCIcoSXm5gG&pl=24&ms=au&mv=m&mt=1494846502&signature=734B1195F1BFC270F141F56C0A40377323331FA9.CD290B6B091572453747BF0EF022373FF3ED2F44&ip=91.208.153.1&mm=31&initcwndbps=15907500&id=o-ALbV2WBuug3gn7JH1n7CikBB1h5YbCWifblyDVe3Dt7Y&mn=sn-8xb5-qo3l&clen=3889492&gir=yes",
            "https://r2---sn-8xb5-qo3e.googlevideo.com/videoplayback?mv=m&mt=1494846564&ms=au&ei=o4wZWY6zItS9cZfgqtgF&ip=91.208.153.1&pl=24&mime=video%2Fmp4&mn=sn-8xb5-qo3e&mm=31&id=o-AI9dCv99BeTElSJa-MdpBWfeFrxsTp75feAuVQBwCfTN&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&clen=4099564&initcwndbps=9047500&ipbits=0&dur=53.011&source=youtube&lmt=1494156396710854&requiressl=yes&key=yt6&signature=85F17CADD25A370349023CE91E5301E2CFCEEB67.7879111FEF6F3E1CB4AAE19AAC5C7031120F2995&gir=yes&itag=18&expire=1494868227&upn=n5QMpvIwYGI&ratebypass=yes",
            "https://r2---sn-8xb5-qo3e.googlevideo.com/videoplayback?initcwndbps=9047500&ei=vYwZWb-hDYvAcbqYiqAD&dur=44.675&expire=1494868253&ipbits=0&mm=31&mn=sn-8xb5-qo3e&id=o-AHTKxL_fhmWQ2s-73_8kueDJ4kzqy2jtxpIK0lbGP1Ft&mime=video%2Fmp4&pl=24&mt=1494846564&mv=m&gir=yes&ms=au&ip=91.208.153.1&requiressl=yes&signature=179436DCC2E2F439F2A7704D9E994CEBA55A7355.4622D318079DB4717EE678E36FF0F7835AF826ED&upn=H_MfaTOqahg&ratebypass=yes&key=yt6&lmt=1494157821417922&itag=18&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&source=youtube&clen=3876194",
            "https://r2---sn-8xb5-qo3l.googlevideo.com/videoplayback?requiressl=yes&ip=91.208.153.1&pcm2cms=yes&mv=m&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpcm2cms%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&mt=1494846564&pl=24&id=o-ACUVNwdaZAEVXUNO0P6SUf9DkqXlcszB93Va8ICk4xVw&mn=sn-8xb5-qo3l&mm=31&lmt=1494159248912224&source=youtube&upn=nf02eV9k4YY&ms=au&ei=zYwZWfX7GNOwcdOcgLgP&key=yt6&gir=yes&mime=video%2Fmp4&initcwndbps=15907500&itag=18&clen=5735517&signature=56FD07F595631FDB6975E5BE52C4E1E1DEC62AB8.65D7D0988DB18CEDB0096862B0EF385C1A814454&dur=77.926&ipbits=0&expire=1494868269&ratebypass=yes",
            "https://r1---sn-8xb5-qo3e.googlevideo.com/videoplayback?mt=1494846619&mv=m&dur=47.345&initcwndbps=9186250&itag=18&ms=au&sparams=clen%2Cdur%2Cei%2Cgir%2Cid%2Cinitcwndbps%2Cip%2Cipbits%2Citag%2Clmt%2Cmime%2Cmm%2Cmn%2Cms%2Cmv%2Cpl%2Cratebypass%2Crequiressl%2Csource%2Cupn%2Cexpire&id=o-AIPy5dgXOFpx9OUqpvtN26-08NrhR5AmXvjw9kczihSS&ipbits=0&ip=91.208.153.1&mm=31&mn=sn-8xb5-qo3e&pl=24&ei=34wZWaO7G8WKcODLgPgM&key=yt6&source=youtube&upn=JxYsvaOMvjM&clen=4369404&signature=40DB2A2E00FD5225C86E0FE6BF641DFEF769421B.7984BB5062409A7654E6D4696F1BB8A6D5300851&ratebypass=yes&lmt=1494160687818259&expire=1494868287&requiressl=yes&gir=yes&mime=video%2Fmp4",
        };

	public void trickVideoRedirect(int trick){
		switch(trick){
			case 1 : Application.OpenURL("https://www.youtube.com/watch?v=LFNTOwEywkk");
			break;
			case 2 : Application.OpenURL("https://www.youtube.com/watch?v=6p1PXVG473k");
			break;
			case 3 : Application.OpenURL("https://www.youtube.com/watch?v=w_viPNpkcE0");
			break;
			case 4 : Application.OpenURL("https://www.youtube.com/watch?v=YvnNvl-bFbk");
			break;
			case 5 : Application.OpenURL("https://www.youtube.com/watch?v=3a8wLFwvXGw");
			break;
			case 6 : Application.OpenURL("https://www.youtube.com/watch?v=jfe-Bd9QNiM");
			break;
			case 7 : Application.OpenURL("https://www.youtube.com/watch?v=RNw6xUJa9iM");
			break;
			case 8 : Application.OpenURL("https://www.youtube.com/watch?v=8U0YEEbxyEg");
			break;
			case 9 : Application.OpenURL("https://www.youtube.com/watch?v=sA1QkuF985Ms");
			break;
		}
	}

    public void ShowFullScreenVideo(int trick)
    {
        Handheld.PlayFullScreenMovie(urls[trick - 1], Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFit);
    }
}
