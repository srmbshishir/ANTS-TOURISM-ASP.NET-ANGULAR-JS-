using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ANTSBackend.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("api/Customer/GetAll")]
        [HttpGet]
        public List<UserModel> GetAllCustomers()
        {
            return CustomerService.GetCustomers();
        }

        [Route("api/Customer/{id}/Details")]
        public CustomerDetails GetCustomerDetails(int id)
        {
            return CustomerService.GetCustomerDetails(id);
        }

        [Route("api/Packages/GetAll")]
        [HttpGet]
        public List<PackageModel> GetPackages()
        {
            return CustomerService.GetPackages();
        }

        [Route("api/Notices/GetAll")]
        [HttpGet]
        public List<NoticeModel> GetNotices()
        {
            return CustomerService.GetNotices();
        }

        [Route("api/Blogs/GetAll")]
        [HttpGet]
        public List<BlogsModel> GetBlogs()
        {
            return CustomerService.GetBlogs();
        }
        [Route("api/Blogs/add")]
        [HttpPost]

        public BlogsModel AddBlogs(BlogsModel blogs)
        {
            return CustomerService.AddBlogs(blogs);
        }

        [Route("api/Blogs/edit/{id}")]
        [HttpPost]
        public BlogsModel EditBlogs(BlogsModel blogs)
        {
            return CustomerService.EditBlogs(blogs);
        }

        [Route("api/Blogs/delete/{id}")]
        [HttpGet]
        public BlogsModel DeleteBlog(int id)
        {
            return CustomerService.DeleteBlogs(id);
        }
    }
}
