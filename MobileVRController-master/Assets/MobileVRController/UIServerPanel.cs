using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIServerPanel : MonoBehaviour {

	public RectTransform ConfigPanel;
    public Slider LightSlider;
    public Toggle GUIToggle;
    public Toggle ModelToggle;
    public Text LightText;
	public Text ConfigButton;
    public Text OnOffButton;
	public Text IPAddress;
	public ServiceManager ServiceMngr;
    public ColorPicker RGBAPicker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ToggleConfig()
	{
		ConfigPanel.gameObject.SetActive (!ConfigPanel.gameObject.activeSelf);
		ConfigButton.text = ConfigPanel.gameObject.activeSelf ? "<" : ">";
	}
	public void ConnectTo()
	{
		ServiceMngr.ConnectTo (IPAddress.text);
	}

    public void LightSliderValue()
    {
        ServiceMngr.TorchRange(LightSlider.value * 100);
        LightText.text = (LightSlider.value * 100).ToString("0.00");
    }

    public void ToggleOnOff()
    {
        LightSlider.gameObject.SetActive(!LightSlider.gameObject.activeSelf);
        OnOffButton.text = LightSlider.gameObject.activeSelf ? "Off" : "On";
        ServiceMngr.SetTorchActive(LightSlider.gameObject.activeSelf);
    }

    public void RGBAValue()
    {
        ServiceMngr.SetTorchColor(RGBAPicker.R, RGBAPicker.G, RGBAPicker.B, RGBAPicker.A);
    }

    public void ToggleGUIDebug()
    {
        ServiceMngr.SetGUIDebug(GUIToggle.isOn);
    }

    public void ToggleShowModel()
    {
        ServiceMngr.ShowModel(ModelToggle.isOn);
    }
}
