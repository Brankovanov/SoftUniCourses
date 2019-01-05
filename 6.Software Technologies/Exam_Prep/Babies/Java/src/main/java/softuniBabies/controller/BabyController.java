package softuniBabies.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import softuniBabies.bindingModel.BabyBindingModel;
import softuniBabies.entity.Baby;
import softuniBabies.repository.BabyRepository;

import java.util.List;

@Controller
public class BabyController {
    private final BabyRepository babyRepository;

    @Autowired
    public BabyController(BabyRepository reportRepository) {
        this.babyRepository = reportRepository;
    }

    @GetMapping("/")
    public String index(Model model) {
        // TODO
        return null;
    }

    @GetMapping("/create")
    public String create(Model model) {
        // TODO
        return null;
    }

    @PostMapping("/create")
    public String createProcess(BabyBindingModel babyBindingModel) {
        // TODO
        return null;

    }

    @GetMapping("/edit/{id}")
    public String edit(Model model, @PathVariable int id) {
        // TODO
        return null;
    }

    @PostMapping("/edit/{id}")
    public String editProcess(BabyBindingModel babyBindingModel, @PathVariable int id) {
        // TODO
        return null;
    }

    @GetMapping("/delete/{id}")
    public String delete(Model model, @PathVariable int id) {
        // TODO
        return null;
    }

    @PostMapping("/delete/{id}")
    public String deleteProcess(@PathVariable int id) {
        // TODO
        return null;
    }
}
