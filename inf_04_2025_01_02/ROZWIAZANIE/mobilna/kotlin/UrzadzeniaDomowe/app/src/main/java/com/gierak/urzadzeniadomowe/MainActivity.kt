package com.gierak.urzadzeniadomowe

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        //enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val przyciskWlacz = findViewById<Button>(R.id.button_wlacz)
        val odkurzaczStatusTextView = findViewById<TextView>(R.id.textView_odkurzacz_status)
        var statusOdkurzacza = false

        findViewById<Button>(R.id.button_zatwierdz).setOnClickListener {
            val opcja = findViewById<EditText>(R.id.editTextNumber_nr_prania).text.toString().toInt()
            if(opcja in 1..12){
                findViewById<TextView>(R.id.textView_nr_prania).text = String.format(getString(R.string.numer_prania_string), opcja)
            }

        }

        przyciskWlacz.setOnClickListener {
            if(statusOdkurzacza){
                przyciskWlacz.text = getString(R.string.wlacz)
                odkurzaczStatusTextView.text = getString(R.string.odkurzacz_wylaczony)
                statusOdkurzacza = false
            }else{
                przyciskWlacz.text = getString(R.string.wylacz)
                odkurzaczStatusTextView.text = getString(R.string.odkurzacz_wlaczony)
                statusOdkurzacza = true
            }
        }

    }
}