﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;

public class DStoryDialogue {
	
	[XmlAttribute("CharacterID")]
	public string CID;

	[XmlElement("SoundID")]
	public string SID;

	[XmlElement("TextBody")]
	public string TextBody;
}
