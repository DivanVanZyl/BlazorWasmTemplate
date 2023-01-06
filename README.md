# BlazorWasmTemplate

To run EF Initial migration

(Navigate to Server folder)

dotnet ef migrations add InitialCreate --context DataContext

dotnet ef database update --context DataContext
