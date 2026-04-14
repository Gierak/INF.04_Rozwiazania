package com.gierak.domekwgorach

import android.os.Bundle
import android.widget.Button
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

        var licznik = 0
        var poleLicznika = findViewById<TextView>(R.id.textView_licznik)

        poleLicznika.text = getString(R.string.polubienia_string, licznik)

        findViewById<Button>(R.id.button_usun).setOnClickListener {
            if (licznik > 0) {
                licznik--
                poleLicznika.text = getString(R.string.polubienia_string, licznik)
            }
        }

        findViewById<Button>(R.id.button_polub).setOnClickListener {
            licznik++
            poleLicznika.text = getString(R.string.polubienia_string, licznik)

        }

    }
}