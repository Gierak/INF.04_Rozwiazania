package com.gierak.rejestracja

import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
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

        val tekstKomunikatu = findViewById<TextView>(R.id.textView_komunikaty)

        findViewById<Button>(R.id.button_zatwierdz).setOnClickListener {
            if (!findViewById<EditText>(R.id.editTextText_email).text.contains('@')) {
                tekstKomunikatu.text = getString(R.string.nieprawidlowy_adres_email)
                return@setOnClickListener
            }

            if (findViewById<EditText>(R.id.editTextTextPassword_haslo).text.toString() != findViewById<EditText>(
                    R.id.editTextTextPassword_powtorz_haslo
                ).text.toString()
            ) {
                tekstKomunikatu.text = getString(R.string.hasla_nie_sa_rowne)

                return@setOnClickListener
            }

            tekstKomunikatu.text =
                getString(R.string.witaj, findViewById<EditText>(R.id.editTextText_email).text)

        }
    }
}