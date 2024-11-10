using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kendaraan.Models;

namespace Kendaraan.Controllers;

public class HomeController : Controller
{
    private static List<VehicleModel> vehicles = new List<VehicleModel>();

    public ActionResult Index()
    {
        return View(vehicles);
    }

    [HttpPost]
    public ActionResult AddVehicle(VehicleModel vehicle)
    {
        if (ModelState.IsValid)
        {
            vehicles.Add(vehicle);
        }
        return RedirectToAction("Index");
    }

    public ActionResult Detail(string id)
    {
        var vehicle = vehicles.Find(v => v.NomorRegistrasiKendaraan == id);
        return View(vehicle);
    }

    public ActionResult Edit(string id)
    {
        var vehicle = vehicles.Find(v => v.NomorRegistrasiKendaraan == id);
        return View(vehicle);
    }

    [HttpPost]
    public ActionResult Edit(VehicleModel updatedVehicle)
    {
        var index = vehicles.FindIndex(v => v.NomorRegistrasiKendaraan == updatedVehicle.NomorRegistrasiKendaraan);
        if (index != -1)
        {
            vehicles[index] = updatedVehicle;
        }
        return RedirectToAction("Index");
    }

    public ActionResult Delete(string id)
    {
        var vehicle = vehicles.Find(v => v.NomorRegistrasiKendaraan == id);
        if (vehicle != null)
        {
            vehicles.Remove(vehicle);
        }
        return RedirectToAction("Index");
    }
}