package com.example.demo.controllers;
import com.example.demo.models.split;
import com.example.demo.models.splitInput;
import com.example.demo.services.splitService;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@CrossOrigin(origins = "*", allowedHeaders = "*")
@RequestMapping("/split")
public class splitController {
    @Autowired
    splitService splitService;
    private split split1 = new split();

    @GetMapping()
    public split obtenerSplit(){
        return split1;
    }

    @PostMapping()
    public split guardarSplit(@RequestBody splitInput x) {
        split1 = splitService.modifySplit(x);
        return split1;
    }
}
