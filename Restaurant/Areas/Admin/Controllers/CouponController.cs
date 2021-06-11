using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;
using Restaurant.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.ManagerUser)]
    [Area("Admin")]
    public class CouponController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CouponController (ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _db.Coupon.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (Coupon coupons)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    byte[] p1 = null;
                    using(var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    coupons.Picture = p1;
                }
                _db.Coupon.Add(coupons);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coupons);
        }//END OF CREATE POST

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();

            }
            else
            {
                var coupon = await _db.Coupon.FindAsync(id);
                if (coupon == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(coupon);
                }
            }
        }//END OF DETAILS



        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var coupon = await _db.Coupon.FindAsync(id);
                if (coupon == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(coupon);
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Coupon coupon)
        {

            if (coupon == null)
                return NotFound();
            if (coupon.Id == 0)
                return NotFound();
            if (!ModelState.IsValid)
                return View(coupon);

            Coupon couponFromDb = await _db.Coupon.FindAsync(coupon.Id);

            couponFromDb.isActive = coupon.isActive;
            couponFromDb.MinimumAmount = coupon.MinimumAmount;
            couponFromDb.Name = coupon.Name;
            couponFromDb.Picture = coupon.Picture;
            couponFromDb.CouponType = coupon.CouponType;
            couponFromDb.Discount = coupon.Discount;

            var files = HttpContext.Request.Form.Files;
            if (files.Count > 0)
            {
                byte[] p1 = null;
                using (var fs1 = files[0].OpenReadStream())
                {
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();
                    }
                }
                couponFromDb.Picture = p1;
                _db.Coupon.Update(couponFromDb);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(coupon);
            }

        }//END OF EDIT

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var coupon = await _db.Coupon.FindAsync(id);
                if (coupon == null)
                {
                    return NotFound();
                }
                else
                {
                    return View(coupon);
                }
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {

            var coupon = await _db.Coupon.FindAsync(id);

            if (coupon == null)
                return View();

            _db.Coupon.Remove(coupon);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
    }
}
