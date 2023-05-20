// See https://aka.ms/new-console-template for more information
using BridgePattern;

Payment payment=new CardPayment();

payment._paymenentSystem = new CitiPaymentSystem();

payment.MakePayment();
payment._paymenentSystem = new IDBIPaymentSystem();

payment.MakePayment();

payment = new NetBankPayment();

payment._paymenentSystem = new CitiPaymentSystem();

payment.MakePayment();
payment._paymenentSystem = new IDBIPaymentSystem();

payment.MakePayment();


Console.ReadLine();
