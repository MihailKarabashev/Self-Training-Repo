using AccountState;

var account = new Account("Ivan Ivanov");

account.Deposit(500);
account.Deposit(601);

account.Withdraw(100);
account.Withdraw(200);
account.Withdraw(850);

account.Withdraw(100);