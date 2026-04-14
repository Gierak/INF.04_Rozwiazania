package com.gierak.koty

import android.os.Bundle
import android.text.Editable
import android.text.TextWatcher
import android.widget.Button
import android.widget.EditText
import android.widget.ImageView
import android.widget.LinearLayout
import android.widget.Switch
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

        val zdjecie = findViewById<ImageView>(R.id.imageView_zdjecie)
        val poleNumeryczne = findViewById<EditText>(R.id.editTextNumber_obraz)
        val tlo = findViewById<LinearLayout>(R.id.main)
        val obrazy = arrayOf(R.drawable.kot1, R.drawable.kot2, R.drawable.kot3, R.drawable.kot4)
        var terazObraz = 0

        findViewById<Button>(R.id.button_nastepny).setOnClickListener {
            if (terazObraz < obrazy.size - 1)
                terazObraz++
            else
                terazObraz = 0
            zdjecie.setImageResource(obrazy[terazObraz])
        }

        findViewById<Button>(R.id.button_wczesniej).setOnClickListener {
            if (terazObraz <= 0) {
                terazObraz = obrazy.size - 1
            } else {
                terazObraz--
            }
            zdjecie.setImageResource(obrazy[terazObraz])
        }



        poleNumeryczne.addTextChangedListener(object : TextWatcher {
            override fun afterTextChanged(p0: Editable?) {

            }

            override fun beforeTextChanged(
                p0: CharSequence?,
                p1: Int,
                p2: Int,
                p3: Int
            ) {

            }

            override fun onTextChanged(
                p0: CharSequence?,
                p1: Int,
                p2: Int,
                p3: Int
            ) {
                if(p0.toString() == "") return
                if (arrayOf(1, 2, 3, 4).contains(p0.toString().toInt())) {
                    terazObraz = p0.toString().toInt() - 1
                    zdjecie.setImageResource(obrazy[terazObraz])
                }
            }
        })

        findViewById<Switch>(R.id.switch_tlo).setOnCheckedChangeListener { _, status ->
            if(status){
                tlo.setBackgroundColor(getColor(R.color.blue))
            }else{
                tlo.setBackgroundColor(getColor(R.color.light_green))
            }
        }


    }
}