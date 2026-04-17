package com.gierak.quiz

import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.ImageView
import android.widget.RadioButton
import android.widget.RadioGroup
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

        val pytania = arrayOf(Pytania("Które to schronisko?","Na Rysiance.","Na Wielkiej Raczy.","Na Wielkiej Rycerzowej.",'B',R.drawable.zad1),
            Pytania("Zwierzę na zdjęciu to","owczarek.","wilk.","kozica.",'A',R.drawable.zad2),
            Pytania("W oddali są widoczne","Himalaje.","Alpy.","Tatry.",'C',R.drawable.zad3))

        var aktualnie = 0
        var punkty =0

        findViewById<Button>(R.id.button_dalej).setOnClickListener {
            val zaznaczony = findViewById<RadioGroup>(R.id.radioGroup_grupa).checkedRadioButtonId
            if(zaznaczony !=-1){
                val radiobutton1 = findViewById<RadioButton>(zaznaczony)
                if(radiobutton1.tag.toString()[0]==pytania[aktualnie].poprawna){
                    punkty++
                }
                Log.d("punkty",punkty.toString())
            }

            if(aktualnie < pytania.size-1){
                aktualnie++
            }else{
                aktualnie=0
            }
            findViewById<TextView>(R.id.textview_pytanie).text = pytania[aktualnie].pytanie
            findViewById<RadioButton>(R.id.radioButton_odpA).text = pytania[aktualnie].odpowiedzA
            findViewById<RadioButton>(R.id.radioButton_odpB).text = pytania[aktualnie].odpowiedzB
            findViewById<RadioButton>(R.id.radioButton_odpC).text = pytania[aktualnie].odpowiedzC
            findViewById<ImageView>(R.id.imageView_zdjecie).setImageResource(pytania[aktualnie].zdjecie)
            findViewById<RadioGroup>(R.id.radioGroup_grupa).clearCheck()
        }

    }
}
