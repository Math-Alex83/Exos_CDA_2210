class Employe{
    constructor(donnees){
        Object.assign(this,donnees);
        this.email = this.calculateMail();
    }

    calculateMail(){
        let name = this.employee_name.trim().split(" ");
        return (name[0].charAt(0)+"."+name[1]+"@email.com").toLowerCase();
    }

    calculateMonthSalary(){
        return (this.employee_salary/12).toFixed(2);
    }
    calcuateYearOfBirth(){
        const dateToday = new Date();
       return dateToday.getFullYear()-this.employee_age;
    }
}

export { Employe };