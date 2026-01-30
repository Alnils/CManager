using CManager.Application.Interfaces;
using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Presentation.ConsoleApp.Controllers;

public sealed class MenuController(ICustomerService customerService)
{
    private readonly ICustomerService _customerService = customerService;

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to CManager!");
            Console.WriteLine("Select option:");
            Console.WriteLine("1. Create customer");
            Console.WriteLine("2. List customers");
            Console.WriteLine("3. View customer by email");
            Console.WriteLine("4. Delete customer by email");
            Console.WriteLine("5. Exit");

            var optionSelect = Console.ReadLine();
            switch (optionSelect)
            {
                case "1":
                    CreateCustomer();
                    break;
                case "2":
                    ListCustomers();
                    break;
                case "3":
                    ViewCustomerByEmail();
                    break;
                case "4":
                    DeleteCustomerByEmail();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    Pause();
                    break;
            }
        }
    }

    private void CreateCustomer()
    {
        Console.Clear();
        Console.WriteLine("Create customer");

        var request = new CreateCustomerRequest();
        request.FirstName = Prompt("First name:");
        request.LastName = Prompt("Last name:");
        request.Email = Prompt("Email:");
        request.Phone = Prompt("Phone (optional):");

        // Address information
        var street = Prompt("Street:");
        var zip = Prompt("Zip code:");
        var city = Prompt("City:");

        try
        {
            var result = _customer_service_AddSafe(request);
            if (result != null)
                Console.WriteLine(result.Message ?? (result.IsSuccess ? "Customer created" : "Could not create customer"));
            else
                Console.WriteLine("Add operation not available");

            if (result != null && result.IsSuccess)
            {
                // Try to attach address if service supports update
                var getRes = GetByEmailSafe(request.Email);
                if (getRes != null && getRes.IsSuccess && getRes.Result != null)
                {
                    getRes.Result.Adress = new Adress { Street = street, ZipCode = zip, City = city };
                    try
                    {
                        var upd = _customer_service_UpdateSafe(getRes.Result);
                        if (upd != null)
                            Console.WriteLine(upd.Message ?? (upd.IsSuccess ? "Customer updated with address" : "Could not update address"));
                    }
                    catch
                    {
                        Console.WriteLine("Address collected but could not be saved");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Pause();
    }

    private void ListCustomers()
    {
        Console.Clear();
        Console.WriteLine("Customers:");

        try
        {
            var all = GetAllSafe();
            if (all != null && all.IsSuccess && all.Result != null)
            {
                foreach (var c in all.Result)
                {
                    Console.WriteLine($"- {c.FirstName} {c.LastName} | {c.Email}");
                }
            }
            else
            {
                Console.WriteLine(all?.Message ?? "No customers found");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Pause();
    }

    private void ViewCustomerByEmail()
    {
        Console.Clear();
        var email = Prompt("Enter customer's email:");

        try
        {
            var res = GetByEmailSafe(email);
            if (res != null && res.IsSuccess && res.Result != null)
            {
                var c = res.Result;
                Console.WriteLine($"Name: {c.FirstName} {c.LastName}");
                Console.WriteLine($"Id: {c.Id}");
                Console.WriteLine($"Email: {c.Email}");
                Console.WriteLine($"Phone: {c.Phone ?? "N/A"}");
                if (c.Adress != null)
                {
                    Console.WriteLine("Address:");
                    Console.WriteLine($"  Street: {c.Adress.Street}");
                    Console.WriteLine($"  Zip: {c.Adress.ZipCode}");
                    Console.WriteLine($"  City: {c.Adress.City}");
                }
                else
                {
                    Console.WriteLine("Address: N/A");
                }
            }
            else
            {
                Console.WriteLine(res?.Message ?? "Customer not found");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Pause();
    }

    private void DeleteCustomerByEmail()
    {
        Console.Clear();
        var email = Prompt("Enter customer's email to delete:");

        try
        {
            var getRes = GetByEmailSafe(email);
            if (getRes == null || !getRes.IsSuccess || getRes.Result == null)
            {
                Console.WriteLine(getRes?.Message ?? "Customer not found");
                Pause();
                return;
            }

            var id = getRes.Result.Id.ToString();
            var del = DeleteSafe(id);
            if (del != null)
                Console.WriteLine(del.Message ?? (del.IsSuccess ? "Customer deleted" : "Could not delete customer"));
            else
                Console.WriteLine("Delete operation not available");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Pause();
    }

    private string Prompt(string message)
    {
        Console.Write(message + " ");
        return Console.ReadLine() ?? string.Empty;
    }

    private void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(true);
    }

    // Safe wrappers for service methods that may not be implemented yet
    private CustomerResult? _customer_service_AddSafe(CreateCustomerRequest req)
    {
        try { return _customerService.Add(req); } catch { return null; }
    }

    private CustomerResult? _customer_service_UpdateSafe(Customer req)
    {
        try { return _customerService.Update(req); } catch { return null; }
    }

    private CustomerObjectResult<IEnumerable<Customer>>? GetAllSafe()
    {
        try { return _customerService.GetAll(); } catch { return null; }
    }

    private CustomerObjectResult<Customer>? GetByEmailSafe(string email)
    {
        try { return _customerService.GetByEmail(email); } catch { return null; }
    }

    private CustomerResult? DeleteSafe(string id)
    {
        try { return _customerService.Delete(id); } catch { return null; }
    }
}
