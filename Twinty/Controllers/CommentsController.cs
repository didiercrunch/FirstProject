namespace Twinty.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class CreateCommentRequest{
    public string Name { get; set; }
    public string Comment { get; set; }
}

public class CreateCommentResponse{
    public bool? Succeed { get; set; }
}

public class CommentsController : Controller{

    [HttpGet]
    public IActionResult Index(){
        return View();
    }
    
    [HttpPost]
    [ActionName("create-comment")]
    public IActionResult CreateComment([FromBody] CreateCommentRequest req){
        ViewData["Name"] = req.Name;
        ViewData["Comment"] = req.Comment;
        return View("PartialComment");
    }
}