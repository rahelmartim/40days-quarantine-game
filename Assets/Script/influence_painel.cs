using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class influence_painel : MonoBehaviour
{
    [SerializeField] Game_Controller controller;

    [SerializeField] Text percent_economy;
    [SerializeField] Text percent_health;
    [SerializeField] Text percent_politics;
    [SerializeField] Text percent_population;
    [SerializeField] Text percent_research;

    [SerializeField] Color color_increased;
    [SerializeField] Color color_decreased;
    [SerializeField] Color color_neutral;

    [SerializeField] GameObject up_arrow_economy;
    [SerializeField] GameObject down_arrow_economy;

    [SerializeField] GameObject up_arrow_health;
    [SerializeField] GameObject down_arrow_health;

    [SerializeField] GameObject up_arrow_politics;
    [SerializeField] GameObject down_arrow_politics;

    [SerializeField] GameObject up_arrow_population;
    [SerializeField] GameObject down_arrow_population;

    [SerializeField] GameObject up_arrow_research;
    [SerializeField] GameObject down_arrow_research;

    [SerializeField] Slider bar_economy;
    [SerializeField] Slider bar_health;
    [SerializeField] Slider bar_politics;
    [SerializeField] Slider bar_population;
    [SerializeField] Slider bar_research;

    [SerializeField] Text relatory_1;
    [SerializeField] Text relatory_2;
    [SerializeField] Text relatory_3;

    void Start()
    {
        //relatory_1.text = "";
        //relatory_2.text = "";
        //relatory_3.text = "";
        /*
        color_increased = new Color(8, 185, 8, 255);
        color_decreased = new Color(222, 35, 24, 255);
        color_neutral = new Color(0, 0, 0, 255);
        */

        bar_economy.interactable = false;
        bar_health.interactable = false;
        bar_politics.interactable = false;
        bar_population.interactable = false;
        bar_research.interactable = false;

        bar_economy.maxValue = 100;
        bar_economy.minValue = 0;

        bar_health.maxValue = 100;
        bar_health.minValue = 0;

        bar_politics.maxValue = 100;
        bar_politics.minValue = 0;

        bar_population.maxValue = 100;
        bar_population.minValue = 0;

        bar_research.maxValue = 100;
        bar_research.minValue = 0;

        bar_economy.value = controller.influence_economy;
        bar_health.value = controller.influence_health;
        bar_politics.value = controller.influence_politics;
        bar_population.value = controller.influence_population;
        bar_research.value = controller.influence_research;

    }
    
    void Update()
    {
        
    }

    public void update_influences()
    {
        relatory_1.text = controller.fist_notice;
        relatory_2.text = controller.second_notice;
        relatory_3.text = controller.third_notice;

        bar_economy.value = controller.influence_economy;
        bar_health.value = controller.influence_health;
        bar_politics.value = controller.influence_politics;
        bar_population.value = controller.influence_population;
        bar_research.value = controller.influence_research;

        percent_economy.text = controller.influence_economy.ToString() + "%";
        if (controller.influence_economy_increased > 0)
        {
            up_arrow_economy.SetActive(true);
            down_arrow_economy.SetActive(false);
            percent_economy.color = color_increased;
        }
        else if (controller.influence_economy_increased < 0)
        {
            up_arrow_economy.SetActive(false);
            down_arrow_economy.SetActive(true);
            percent_economy.color = color_decreased;
        }
        else
        {
            up_arrow_economy.SetActive(false);
            down_arrow_economy.SetActive(false);
            percent_economy.color = color_neutral;
        }
            
        percent_health.text = controller.influence_health.ToString() + "%";
        if (controller.influence_health_increased > 0)
        {
            up_arrow_health.SetActive(true);
            down_arrow_health.SetActive(false);
            percent_health.color = color_increased;
        }
        else if (controller.influence_health_increased < 0)
        {
            up_arrow_health.SetActive(false);
            down_arrow_health.SetActive(true);
            percent_health.color = color_decreased;
        }
        else
        {
            up_arrow_health.SetActive(false);
            down_arrow_health.SetActive(false);
            percent_health.color = color_neutral;
        }

        percent_politics.text = controller.influence_politics.ToString() + "%";
        if (controller.influence_politics_increased > 0)
        {
            up_arrow_politics.SetActive(true);
            down_arrow_politics.SetActive(false);
            percent_politics.color = color_increased;
        }
        else if (controller.influence_politics_increased < 0)
        {
            up_arrow_politics.SetActive(false);
            down_arrow_politics.SetActive(true);
            percent_politics.color = color_decreased;
        }
        else
        {
            up_arrow_politics.SetActive(false);
            down_arrow_politics.SetActive(false);
            percent_politics.color = color_neutral;
        }

        percent_population.text = controller.influence_population.ToString() + "%";
        if (controller.influence_population_increased > 0)
        {
            up_arrow_population.SetActive(true);
            down_arrow_population.SetActive(false);
            percent_population.color = color_increased;
        }
        else if (controller.influence_population_increased < 0)
        {
            up_arrow_population.SetActive(false);
            down_arrow_population.SetActive(true);
            percent_population.color = color_decreased;
        }
        else
        {
            up_arrow_population.SetActive(false);
            down_arrow_population.SetActive(false);
            percent_population.color = color_neutral;
        }

        percent_research.text = controller.influence_research.ToString() + "%";
        if (controller.influence_research_increased > 0)
        {
            up_arrow_research.SetActive(true);
            down_arrow_research.SetActive(false);
            percent_research.color = color_increased;
        }
        else if (controller.influence_research_increased < 0)
        {
            up_arrow_research.SetActive(false);
            down_arrow_research.SetActive(true);
            percent_research.color = color_decreased;
        }
        else
        {
            up_arrow_research.SetActive(false);
            down_arrow_research.SetActive(false);
            percent_research.color = color_neutral;
        }
    }


}
