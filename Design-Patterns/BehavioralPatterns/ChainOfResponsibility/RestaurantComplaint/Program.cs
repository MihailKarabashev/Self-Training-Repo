using RestaurantComplaint;
using RestaurantComplaint.Models;
using RestaurantComplaint.Enums;

var waiter = RestaurantChain.GetEmployee();

var complaint1 = new Complaint() { CustomerName = "Ivan", Priority = Priority.Low };
waiter.ProcessComplaint(complaint1);

var complaint2 = new Complaint() { CustomerName = "Dragan", Priority = Priority.Medium };
waiter.ProcessComplaint(complaint2);

var complaint3 = new Complaint() { CustomerName = "Petkan", Priority = Priority.High };
waiter.ProcessComplaint(complaint3);

var complaint4 = new Complaint() { CustomerName = "NoName", Priority = Priority.Crutial };
waiter.ProcessComplaint(complaint4);