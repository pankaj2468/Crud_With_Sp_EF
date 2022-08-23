Create procedure [dbo].[AddNewEmpDetails]  
(  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Insert into Employee values(@Name,@City,@Address)  
End 
go
Create Procedure [dbo].[GetEmployees]  
as  
begin  
   select *from Employee  
End
go
Create procedure [dbo].[UpdateEmpDetails]  
(  
   @EmpId int,  
   @Name varchar (50),  
   @City varchar (50),  
   @Address varchar (50)  
)  
as  
begin  
   Update Employee   
   set Name=@Name,  
   City=@City,  
   Address=@Address  
   where EmpId=@EmpId  
End 
go
Create procedure [dbo].[DeleteEmpById]  
(  
   @EmpId int  
)  
as   
begin  
   Delete from Employee where EmpId=@EmpId  
End 