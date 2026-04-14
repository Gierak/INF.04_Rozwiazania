package com.gierak.notatkitekstowe

import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val lista  = mutableListOf("Zakupy: chleb, masło, ser",
            "Do zrobienia: obiad, umyć podłogi",
            "weekend: kino, spacer z psem")

        val listView = findViewById<ListView>(R.id.listview_lista)
        val adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, lista)
        listView.adapter = adapter

        findViewById<Button>(R.id.button_dodaj).setOnClickListener {
            val nowyElement = findViewById<EditText>(R.id.editTextText_element).text.toString()
            lista.add(nowyElement)
            adapter.notifyDataSetChanged()
        }

    }
}