using RestaurantComplaint;
using RestaurantComplaint.Models;
using RestaurantComplaint.Enums;

var employee = RestaurantChain.GetEmployee();

var complaint1 = new Complaint() { CustomerName = "Ivan", Priority = Priority.Low };
employee.ProcessComplaint(complaint1);

var complaint2 = new Complaint() { CustomerName = "Dragan", Priority = Priority.Medium };
employee.ProcessComplaint(complaint2);

var complaint3 = new Complaint() { CustomerName = "Petkan", Priority = Priority.High };
employee.ProcessComplaint(complaint3);

var complaint4 = new Complaint() { CustomerName = "NoName", Priority = Priority.Crutial };
employee.ProcessComplaint(complaint4);