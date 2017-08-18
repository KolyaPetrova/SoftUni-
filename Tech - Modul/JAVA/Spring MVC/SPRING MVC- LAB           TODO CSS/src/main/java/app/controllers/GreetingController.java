package app.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class GreetingController {
    @RequestMapping("/greeting")
    public String greeting(
            @RequestParam(value = "name",
                    defaultValue = "unknown")
                    String personName,
            Model model){
        model.addAttribute("personForGreeting", personName);
        return "greeting";
    }
}
