$managedDatablockSet = new SimSet() {
   canSaveDynamicFields = "1";
      setType = "Datablocks";

   new t2dImageMapDatablock(L3_BackGroundImageMap) {
      imageName = "~/data/images/L3_BackGround.dds";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "1";
      cellCountY = "1";
      cellWidth = "748";
      cellHeight = "512";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(bulletImageMap) {
      imageName = "~/data/images/bullet.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(DandanTarget1ImageMap) {
      imageName = "~/data/images/DandanTarget1.dds";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "4";
      cellCountY = "4";
      cellWidth = "64";
      cellHeight = "92";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(player1ImageMap1) {
      imageName = "~/data/images/player1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "6";
      cellWidth = "192";
      cellHeight = "336";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(player2ImageMap1) {
      imageName = "~/data/images/player2.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "6";
      cellWidth = "193";
      cellHeight = "335";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(player1Animation) {
      imageMap = "player1ImageMap1";
      animationFrames = "7 0 2 0";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player1Animation1) {
      imageMap = "player1ImageMap1";
      animationFrames = "6 3 10 3";
      animationTime = "0.8";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player1Animation2) {
      imageMap = "player1ImageMap1";
      animationFrames = "8 1 5 1";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player1Animation3) {
      imageMap = "player1ImageMap1";
      animationFrames = "4 11 9 11";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(zombie1ImageMap11) {
      imageName = "~/data/images/zombie1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "4";
      cellCountY = "3";
      cellWidth = "218";
      cellHeight = "387";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(zombie1Animation) {
      imageMap = "zombie1ImageMap11";
      animationFrames = "0 8 2 8";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie1Animation1) {
      imageMap = "zombie1ImageMap11";
      animationFrames = "3 7 1";
      animationTime = "0.6";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie1Animation2) {
      imageMap = "zombie1ImageMap11";
      animationFrames = "9 11 10 11";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie1Animation3) {
      imageMap = "zombie1ImageMap11";
      animationFrames = "4 6 5 6";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player2Animation) {
      imageMap = "player2ImageMap1";
      animationFrames = "0 1 2 1";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player2Animation1) {
      imageMap = "player2ImageMap1";
      animationFrames = "4 5 3 5";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player2Animation2) {
      imageMap = "player2ImageMap1";
      animationFrames = "11 9 10 9";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player2Animation3) {
      imageMap = "player2ImageMap1";
      animationFrames = "8 6 7 6";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(beijingImageMap) {
      imageName = "~/data/images/beijing.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(startImageMap) {
      imageName = "~/data/images/start.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(PlayerPic09ImageMap) {
      imageName = "~/data/images/PlayerPic09.dds";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(REP_CURSORImageMap) {
      imageName = "~/data/images/REP_CURSOR.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(boy_1ImageMap11) {
      imageName = "~/data/images/boy_1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "5";
      cellCountY = "1";
      cellWidth = "355";
      cellHeight = "1348";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(girl_1ImageMap1) {
      imageName = "~/data/images/girl_1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "3";
      cellCountY = "1";
      cellWidth = "603";
      cellHeight = "1132";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(particles1ImageMap) {
      imageName = "~/data/images/particles1.dds";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "64";
      cellHeight = "64";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
         canSaveDynamicFields = "1";
   };
   new t2dImageMapDatablock(backgroundImageMap) {
      imageName = "~/data/images/background.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(player1_1ImageMap1) {
      imageName = "~/data/images/player1_1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "3";
      cellWidth = "399";
      cellHeight = "554";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(player1_1Animation) {
      imageMap = "player1_1ImageMap1";
      animationFrames = "0 2 4 2";
      animationTime = "0.8";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player1_1Animation1) {
      imageMap = "player1_1ImageMap1";
      animationFrames = "1 5 3 5";
      animationTime = "0.8";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(player1_2ImageMap11) {
      imageName = "~/data/images/player1_2.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "3";
      cellCountY = "2";
      cellWidth = "303";
      cellHeight = "558";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(player1_2Animation) {
      imageMap = "player1_2ImageMap11";
      animationFrames = "0 2 3 2";
      animationTime = "0.8";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player1_2Animation1) {
      imageMap = "player1_2ImageMap11";
      animationFrames = "1 5 4 5";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(player2_1ImageMap1) {
      imageName = "~/data/images/player2_1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "3";
      cellCountY = "-1";
      cellWidth = "307";
      cellHeight = "556";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(player2_1Animation) {
      imageMap = "player2_1ImageMap1";
      animationFrames = "0 2 4 2";
      animationTime = "0.8";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player2_1Animation1) {
      imageMap = "player2_1ImageMap1";
      animationFrames = "1 3 5 3";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(player2_2ImageMap11) {
      imageName = "~/data/images/player2_2.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "3";
      cellWidth = "408";
      cellHeight = "555";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(player2_2Animation) {
      imageMap = "player2_2ImageMap11";
      animationFrames = "0 2 4 2";
      animationTime = "0.8";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(zombie1_1ImageMap1) {
      imageName = "~/data/images/zombie1_1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "3";
      cellWidth = "391";
      cellHeight = "560";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(zombie1_1Animation) {
      imageMap = "zombie1_1ImageMap1";
      animationFrames = "0 3 5 3";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie1_1Animation1) {
      imageMap = "zombie1_1ImageMap1";
      animationFrames = "4 2 1 2";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(zombie1_2ImageMap1) {
      imageName = "~/data/images/zombie1_2.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "3";
      cellWidth = "393";
      cellHeight = "555";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(zombie1_2Animation) {
      imageMap = "zombie1_2ImageMap1";
      animationFrames = "0 2 4 2";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie1_2Animation1) {
      imageMap = "zombie1_2ImageMap1";
      animationFrames = "5 3 1 3";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(zombie2_1ImageMap11) {
      imageName = "~/data/images/zombie2_1.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "3";
      cellWidth = "346";
      cellHeight = "543";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(zombie2_3ImageMap1) {
      imageName = "~/data/images/zombie2_3.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "3";
      cellCountY = "2";
      cellWidth = "217";
      cellHeight = "426";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(zombie2_4ImageMap1) {
      imageName = "~/data/images/zombie2_4.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "6";
      cellCountY = "1";
      cellWidth = "216";
      cellHeight = "456";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(zombie2_2ImageMap1) {
      imageName = "~/data/images/zombie2_2.png";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "2";
      cellCountY = "3";
      cellWidth = "346";
      cellHeight = "546";
      preload = "0";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dAnimationDatablock(zombie2_1Animation) {
      imageMap = "zombie2_1ImageMap11";
      animationFrames = "0 2 5 2";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie2_1Animation1) {
      imageMap = "zombie2_1ImageMap11";
      animationFrames = "4 3 1 3";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie2_3Animation) {
      imageMap = "zombie2_3ImageMap1";
      animationFrames = "0 3 4 3";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie2_4Animation) {
      imageMap = "zombie2_4ImageMap1";
      animationFrames = "2 5 4 5";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie2_4Animation1) {
      imageMap = "zombie2_4ImageMap1";
      animationFrames = "1 3 0 3";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie2_3Animation1) {
      imageMap = "zombie2_3ImageMap1";
      animationFrames = "2 1 5 1";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie2_2Animation) {
      imageMap = "zombie2_2ImageMap1";
      animationFrames = "0 2 5 2";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(zombie2_2Animation1) {
      imageMap = "zombie2_2ImageMap1";
      animationFrames = "4 3 1 4";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dAnimationDatablock(player2_2Animation1) {
      imageMap = "player2_2ImageMap11";
      animationFrames = "1 3 5 3";
      animationTime = "0.799984";
      animationCycle = "1";
      randomStart = "0";
      startFrame = "0";
      animationPingPong = "0";
      animationReverse = "0";
   };
   new t2dImageMapDatablock(bloodImageMap) {
      imageName = "~/data/images/blood.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(particles5ImageMap) {
      imageName = "~/data/images/particles5.dds";
      imageMode = "CELL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "0";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "64";
      cellHeight = "64";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
         canSaveDynamicFields = "1";
   };
   new t2dImageMapDatablock(wallImageMap) {
      imageName = "~/data/images/wall.png";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "1";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
   new t2dImageMapDatablock(Gold3ImageMap) {
      imageName = "~/data/images/Gold3.dds";
      imageMode = "FULL";
      frameCount = "-1";
      filterMode = "SMOOTH";
      filterPad = "0";
      preferPerf = "1";
      cellRowOrder = "1";
      cellOffsetX = "0";
      cellOffsetY = "0";
      cellStrideX = "0";
      cellStrideY = "0";
      cellCountX = "-1";
      cellCountY = "-1";
      cellWidth = "0";
      cellHeight = "0";
      preload = "1";
      allowUnload = "0";
      force16Bit = "0";
   };
};
