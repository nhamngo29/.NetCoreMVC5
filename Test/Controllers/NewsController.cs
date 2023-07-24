using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Test.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            var aricle = new List<Aricle>
            {
                new Aricle {Id= 1,Title="This is 1",Content="This is content one",Author="Nham Ngo"},
                new Aricle {Id= 2,Title="This is 2",Content="This is content two",Author="Nham Ngo"},
                new Aricle {Id= 3,Title="This is 3",Content="This is content three",Author="Nham Ngo"},
                new Aricle {Id= 4,Title="This is 4",Content="This is content four",Author="Nham Ngo"},
                new Aricle {Id= 5,Title="This is 5",Content="This is content five",Author="Nham Ngo"},
                new Aricle {Id= 6,Title="This is 6",Content="This is content six",Author="Nham Ngo"}
            };
            //Option 1:using viewbag khi dung du lieu nho nen dung cach nay,khong can ep kieu
            //ViewBag.Aricle = aricle;
            //Option 2:using viewdata khi dung du lieu nho nen dung cach nay,kieu nay tra ve kieu key,value phai ep kieu
            ViewData["Aricles"]=aricle;
            //Option 3:using model  cách nào tối ưu nhất,khi dung du lieu lon nen dung cach nay
            return View(aricle);
        }
        public string StringOut(int id, string firstName, string lastName)
        {
            return ($"Say hello from NhamNgo - My number is {id}, first name : {firstName}, last name: {lastName}");
        }
        public IActionResult StringOut2(int id, string firstName, string lastName)
        {
            return Content($"Say hello from NhamNgo - My number is {id}, first name : {firstName}, last name: {lastName}");
        }

    }
    public class Aricle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

    }
}