type EmailAddress = EmailAddress of string
type TelephoneNumber = TelephoneNumber of string
type Contact = 
      EmailAddressOnly of EmailAddress 
    | TelephoneNumberOnly of TelephoneNumber 
    | EmailAddressAndTelephoneNumber of EmailAddress * TelephoneNumber
type Ticket = {Number: int; Description: string; Contact: Contact }

let telephone = "Test" |> TelephoneNumber
let email = "Test" |> EmailAddress
let tickets = [{ Number = 10; Description = "It doesn't work"; Contact = telephone |> Contact.TelephoneNumberOnly };
              { Number = 11; Description = "It doesn't work"; Contact = email |> Contact.EmailAddressOnly };
              { Number = 12; Description = "It doesn't work"; Contact = (email, telephone) |> EmailAddressAndTelephoneNumber }]
tickets |> Seq.iter(fun ticket -> printfn "%A" ticket )