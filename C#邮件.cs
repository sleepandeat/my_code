using System;  
02.using System.Collections.Generic;  
03.using System.Web;  
04.using System.Net.Mail;  
05.using System.Text;  
06.using System.Configuration;  
07.using System.Web.UI;  
08.using System.Web.UI.WebControls;  
09.  
10.public partial class sendmail : System.Web.UI.Page  
11.{  
12.     
13.  
14.    //带附件发送  
15.    public static bool SendMailsf(string fromUser, string fromUserName, string toUser, string toUserName, string cc, string subjectNm, string bodyAll, string fj)  
16.    {  
17.        bool ret = false;  
18.        try  
using System;  
02.using System.Collections.Generic;  
03.using System.Web;  
04.using System.Net.Mail;  
05.using System.Text;  
06.using System.Configuration;  
07.using System.Web.UI;  
08.using System.Web.UI.WebControls;  
09.  
10.public partial class sendmail : System.Web.UI.Page  
11.{  
12.     
13.  
14.    //带附件发送  
15.    public static bool SendMailsf(string fromUser, string fromUserName, string toUser, string toUserName, string cc, string subjectNm, string bodyAll, string fj)  
16.    {  
17.        bool ret = false;  
18.        try  
using System;  
02.using System.Collections.Generic;  
03.using System.Web;  
04.using System.Net.Mail;  
05.using System.Text;  
06.using System.Configuration;  
07.using System.Web.UI;  
08.using System.Web.UI.WebControls;  
09.  
10.public partial class sendmail : System.Web.UI.Page  
11.{  
12.     
13.  
14.    //带附件发送  
15.    public static bool SendMailsf(string fromUser, string fromUserName, string toUser, string toUserName, string cc, string subjectNm, string bodyAll, string fj)  
16.    {  
17.        bool ret = false;  
18.        try  
{  
20.            //Attachment objMailAttachment;  
21.            //创建一个附件对象  
22.            //objMailAttachment = new Attachment("d:\\test.txt");//发送邮件的附件  
23.  
24.  
25.  
26.            objMailAttachment = new Attachment(fj);//发送邮件的附件  
27.  
28.            MailMessage mm = new MailMessage();  
29.            mm.From = new MailAddress(fromUser, fromUserName, Encoding.UTF8);  
30.            mm.To.Add(toUser);  
31.            string[] listc = null;  
32.            try  
33.            {  
34.                if (cc != null && cc != "")  
35.                {  
36.                        listc = cc.Split(',');  
37.                        for (int i = 0; i < listc.Length; i++)  
38.                        {  
39.                            mm.CC.Add(listc[i].ToString());  
40.                        }  
41.                      
42.                }  
43.            }  
44.            catch (Exception list)  
45.            {  
46.                throw list;  
47.            }  
48.  
49.            mm.Attachments.Add(objMailAttachment);//将附件附加到邮件消息对象中  
50.  
51.              
52.            mm.Subject = subjectNm;  
53.            mm.SubjectEncoding = Encoding.UTF8;  
54.            mm.Body = bodyAll;  
55.            mm.BodyEncoding = Encoding.UTF8;  
56.            mm.IsBodyHtml = true;  
57.          //mm.Priority = MailPriority.High;//加急邮件!  
58.  
59.            SmtpClient client = new SmtpClient();  
60.            client.Credentials = new System.Net.NetworkCredential("帐号", "密码");  
61.            client.Host = "主机";  
62.            client.Send(mm);  
63.            ret = true;  
64.        }  
65.        catch (Exception ex)  
66.        {  
67.            throw ex;  
68.        }  
69.        return ret;  
70.    }  
71.  
72.  
73.  
74.}  
