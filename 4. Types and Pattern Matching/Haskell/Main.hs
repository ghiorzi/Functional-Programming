data JobTitle = 
  Intern 
  | Programmer 
  | Engineer 
  | Manager 
  deriving Show

data Employee = Employee {jobTitle :: JobTitle, name :: String} deriving Show

-- pattern matching
getSalary :: Employee -> Double
getSalary (Employee Intern _) = 1000
getSalary (Employee Programmer _) = 1001
getSalary (Employee Engineer _) = 1002
getSalary (Employee Manager _) = 10000

-- pattern matching
promote :: Employee -> Employee
promote (Employee Intern name) = Employee Programmer name
promote (Employee Programmer name) = Employee Engineer name
promote (Employee Engineer name) = Employee Manager name
promote (Employee _ name) = Employee Manager name

showInfo :: Employee -> String
showInfo employee = 
    "{name: \"" ++ (name employee) ++ 
    "\", job title: \"" ++ show (jobTitle employee) ++ 
    "\", salary: " ++ show (getSalary employee) ++ "}"

me :: Employee
me = Employee Programmer "Rodrigo Ghiorzi"

promoted :: Employee
promoted = promote me

main =
  print (showInfo me) >> 
  print (showInfo promoted)