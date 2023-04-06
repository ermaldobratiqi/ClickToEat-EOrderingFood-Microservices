//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

//// ...

//public class UserController : Controller
//{
//    private readonly YourDbContext _context;

//    public UserController(YourDbContext context)
//    {
//        _context = context;
//    }

//    // Get a list of users
//    public async Task<IActionResult> Index()
//    {
//        var users = await _context.Users.ToListAsync();
//        return View(users);
//    }

//    // Edit a user
//    public async Task<IActionResult> Edit(int id)
//    {
//        var user = await _context.Users.FindAsync(id);
//        if (user == null)
//        {
//            return NotFound();
//        }
//        return View(user);
//    }

//    [HttpPost]
//    [ValidateAntiForgeryToken]
//    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Phone,Address")] User user)
//    {
//        if (id != user.Id)
//        {
//            return NotFound();
//        }

//        if (ModelState.IsValid)
//        {
//            try
//            {
//                _context.Update(user);
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!UserExists(user.Id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }
//            return RedirectToAction(nameof(Index));
//        }
//        return View(user);
//    }

//    // Delete a user
//    public async Task<IActionResult> Delete(int id)
//    {
//        var user = await _context.Users.FindAsync(id);
//        if (user == null)
//        {
//            return NotFound();
//        }

//        _context.Users.Remove(user);
//        await _context.SaveChangesAsync();
//        return RedirectToAction(nameof(Index));
//    }

//    private bool UserExists(int id)
//    {
//        return _context.Users.Any(e => e.Id == id);
//    }
//}
