Create procedure UpdateInventory
@Product_ID int,
@Supplier_ID int,
@Quantity int,
@NewQTY int
as
begin
update Inventory Set Quantity= Quantity+@NewQTY
where Product_ID=@Product_ID and Supplier_ID=@Supplier_ID;
end;
go