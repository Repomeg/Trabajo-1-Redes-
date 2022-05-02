package com.example.demo.services;

import java.util.Arrays;
import java.util.List;
import java.util.ArrayList;

import org.springframework.stereotype.Service;

import com.example.demo.models.split;
import com.example.demo.models.splitInput;


@Service

public class splitService {
    public split modifySplit(splitInput x){
        split splitAux = new split();
        String nombreCompleto = x.getNombreCompleto();
        String[] nombres = nombreCompleto.split(" ");
        List<String> nombresList = Arrays.asList(nombres);
        splitAux.setPaterno(nombresList.get(nombresList.size()-2));
        splitAux.setMaterno(nombresList.get(nombresList.size()-1));
        int end = nombresList.size()-1;
        nombresList.set(end, null);
        nombresList.set(end-1, null);

        List<String> list = new ArrayList<String>();

        for(String s : nombresList) {
            if(s != null && s.length() > 0) {
               list.add(s);
            }
        }

        splitAux.setNombres(list);

        return splitAux;
    }
}
