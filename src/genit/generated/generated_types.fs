module generated_types

type Result<'T> =
  {
    Data : 'T
    Errors : string list
  }

type Register =
  {
    UserID : int64
    FirstName : string
    LastName : string
    Email : string
    Password : string
  }

type Login =
  {
    UserID : int64
    Email : string
    Password : string
  }

type Product =
  {
    ProductID : int64
    Name : string
    Description : string
    Price : double
    Category : string
  }

type CartItem =
  {
    CartItemID : int64
    CartFK : int64
    ProductFK : int64
  }

type Cart =
  {
    CartID : int64
    UserFK : int64
    Items : CartItem list
  }

type Checkout =
  {
    CheckoutID : int64
    CartFK : int64
  }
