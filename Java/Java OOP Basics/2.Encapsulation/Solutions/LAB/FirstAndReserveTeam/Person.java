package LAB.FirstAndReserveTeam;

public class Person {
    private String firstName;
    private String lastName;
    private Integer age;
    private Double salary;

    public Person(String firstName, String lastName, Integer age, Double salary) {
        setFirstName(firstName);
        setLastName(lastName);
        setAge(age);
        setSalary(salary);
    }

    private void setFirstName(String firstName) {
        if (firstName.length() < 3) {
            throw new IllegalArgumentException("First name cannot be less than 3 symbols");
        }
        this.firstName = firstName;
    }

    private void setLastName(String lastName) {
        if (lastName.length() < 3) {
            throw new IllegalArgumentException("Last name cannot be less than 3 symbols");
        }
        this.lastName = lastName;
    }

    private void setAge(Integer age) {
        if (age < 1) {
            throw new IllegalArgumentException("Age cannot be zero or negative integer");
        }
        this.age = age;
    }

    private void setSalary(Double salary) {
        if (salary < 460) {
            throw new IllegalArgumentException("Salary cannot be less than 460 leva");
        }
        this.salary = salary;
    }

    public Integer getAge() {
        return this.age;
    }

    public Double getSalary() {

        return this.salary;
    }

    private String getLastName() {

        return this.lastName;
    }

    public String getFirstName() {

        return this.firstName;
    }

    public void increaseSalary(int bonus) {
        if (this.getAge() < 30) {
            this.setSalary(this.getSalary() + this.getSalary() * bonus / 200);
        } else {
           this.setSalary(this.getSalary()+ this.getSalary()*bonus/200);
        }
    }

    @Override
    public String toString() {
        return this.getFirstName() + " " + this.getLastName() + " get " + this.getSalary() + " leva";
    }
}
