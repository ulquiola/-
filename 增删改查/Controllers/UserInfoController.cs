using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using 增删改查.Models;

namespace 增删改查.Controllers
{    
    public class UserInfoController : Controller
    {
        testEntities context = new Models.testEntities();
        // GET: UserInfo
        public ActionResult UserInfo()
        {            
            var userinfo = context.UserInfo;
            return View(userinfo);
        }
        public ActionResult Update(int id)
        {
            //UserInfo userinfo = context.UserInfo.Find(id);
            UserInfo userinfo = context.UserInfo.Where(n => n.UID == id).FirstOrDefault();
            return View(userinfo);
        }
        [HttpPost]
        public ActionResult Update(UserInfo userinfo)
        {
            int x = userinfo.UID;
            string y = userinfo.UName;
            string z = userinfo.UPassWord;
            context.UserInfo.Attach(userinfo);
            context.Entry(userinfo).State = EntityState.Modified;
            int result = context.SaveChanges();
            if(result>0)
            {
                return RedirectToAction("UserInfo");
            }
            else
            {
               return RedirectToAction("Edit", "UseInfo", new { id =userinfo.UID}); 
            }           
            //UserInfo user = context.UserInfo.Where(n => n.UID == userinfo.UID).First();
            //user.UName = userinfo.UName;
            //user.UPassWord = userinfo.UPassWord;
            //context.SaveChanges();
            //return RedirectToAction("UserInfo");            
        }
        public ActionResult Delete(int id)
        {
            UserInfo userinfo = context.UserInfo.Find(id);
            context.UserInfo.Remove(userinfo);
            context.SaveChanges();
            return RedirectToAction("UserInfo");           
        }
        public ActionResult Add()
        {
            UserInfo userinfo = new UserInfo();
            return View(userinfo);
        }
        [HttpPost]
        public ActionResult Add(UserInfo userinfo)
        {
            context.UserInfo.Add(userinfo);
            context.SaveChanges();
            return RedirectToAction("UserInfo");
        }
    }
}