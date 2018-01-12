package entities;

import javax.persistence.*;
import java.util.Set;

@Entity
@Table(name = "departments")
public class Department {
    private Integer id;
    private String name;
    private Employee manager;
    private Set<Employee> employees;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column(name = "department_id")
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(name = "name")
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @ManyToOne
    @JoinColumn(name = "manager_id",referencedColumnName = "employee_id")
    public Employee getManager() {
        return manager;
    }

    public void setManager(Employee manager) {
        this.manager = manager;
    }

    @OneToMany(mappedBy = "department")                     // one department has many employees.
    public Set<Employee> getEmployees() {
        return employees;
    }  // we must map it by property name "department"

    public void setEmployees(Set<Employee> employees) {
        this.employees = employees;
    }
}