package LAB.ValidationDdata;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int n = Integer.parseInt(reader.readLine());

        List<Person> persons = new ArrayList<>();
        Collections.unmodifiableList(persons);

        for (int i = 0; i < n; i++) {
            String[] input = reader.readLine().split(" ");
            try {
                Person person = new Person(input[0], input[1], Integer.parseInt(input[2]), Double.valueOf(input[3]));
                persons.add(person);

            } catch (IllegalArgumentException ex) {
                System.out.println(ex.getMessage());
            }
        }
        if (!persons.isEmpty() && persons.size() != n) {
            System.out.println("--------------------");
        }
        int bonus = Integer.parseInt(reader.readLine());
        for (Person person : persons) {
            person.increaseSalary(bonus);
            System.out.println(person.toString());
        }
    }

}
