package cat.controller;

import cat.entity.Cat;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import cat.bindingModel.CatBindingModel;
import cat.repository.CatRepository;

import java.util.List;

@Controller
public class CatController {
    private final CatRepository catRepository;

    @Autowired
    public CatController(CatRepository catRepository) {
        this.catRepository = catRepository;
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
    public String createProcess(Model model, CatBindingModel catBindingModel) {

        // TODO
        return null;
    }

    @GetMapping("/edit/{id}")
    public String edit(Model model, @PathVariable int id) {

        // TODO
        return null;
    }

    @PostMapping("/edit/{id}")
    public String editProcess(@PathVariable int id, Model model, CatBindingModel catBindingModel) {

        // TODO
        return null;
    }

    @GetMapping("/delete/{id}")
    public String delete(Model model, @PathVariable int id) {

        // TODO
        return null;
    }

    @PostMapping("/delete/{id}")
    public String deleteProcess(@PathVariable int id, CatBindingModel catBindingModel) {

        // TODO
        return null;
    }
}
