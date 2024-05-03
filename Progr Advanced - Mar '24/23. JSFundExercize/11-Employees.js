function getEmployeesData(employeesNames){
    const employeeData = [];

    for(const nameEmployee of employeesNames){
        employeeData.push({
            name: nameEmployee,
            number: nameEmployee.length
        });
    }
    employeeData.forEach((employee) => console.log(`Name: ${employee.name} -- Personal Number: ${employee.number}`));
}

getEmployeesData([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ]
    );