class BufferedHashmap : HashMap<Point> {

    private int bufferWidth;
    public int BufferWidth => bufferWidth;
    private List<List<Point>> bufferTop = new();
    private List<List<Point>> bufferLeft = new();
    private List<List<Point>> bufferRight = new();
    private List<List<Point>> bufferBottom = new();



    public BufferedHashmap(int HashWidth, int HashHeight, int HashBufferWidth = 1) : base(HashWidth, HashHeight) {
        bufferWidth = HashBufferWidth;
        for (int i = 0; i < bufferWidth; i++) {
            bufferTop.Add(new List<Point>());
            bufferLeft.Add(new List<Point>());
            bufferRight.Add(new List<Point>());
            bufferBottom.Add(new List<Point>());

            for (int k = 0; k < Width + bufferWidth * 2; k++) {
                bufferTop[i].Add(new Point());
                bufferBottom[i].Add(new Point());
            }

            for (int k = 0; k < Width; k++) {
                bufferLeft[i].Add(new Point());
                bufferRight[i].Add(new Point());
            }
        }
    }


    public List<List<Point>> GetBufferArea(float x, float y) {
        List<List<Point>> BufferArea = new();
        
        if (x > BufferWidth) {
            if (x < Width - bufferWidth) {
                if (y > bufferWidth) {
                    if (y < Height - bufferWidth) { // No Buffer Intersection
                        for (int i = (int) Math.Floor(x) - bufferWidth; i < Math.Ceiling(x) + bufferWidth; i++) {
                            BufferArea.Add(new List<Point>());

                            for (int k = (int) Math.Floor(y) - bufferWidth; k < Math.Ceiling(y) + bufferWidth; i++) {
                                BufferArea[i].Add(GetPoint(i, k));
                            }
                        }
                    }
                    else { // Bottom Buffer Intersection
                        for (int i = (int) Math.Floor(x) - bufferWidth; i < Math.Ceiling(x) + bufferWidth; i++) {
                            BufferArea.Add(new List<Point>());

                            for (int k = (int) Math.Floor(y) - bufferWidth; k < Height; i++) {
                                BufferArea[i].Add(GetPoint(i, k));
                            }

                            for (int k = 0; k < bufferWidth - (Height - Math.Floor(y)); k++) {
                                BufferArea[i].Add(bufferBottom[i + bufferWidth][k]);
                            }
                        }
                    }
                }
                else {
                    if (y < Height - bufferWidth) { // Top Buffer Intersection
                        for (int i = (int) Math.Floor(x) - bufferWidth; i < Math.Ceiling(x) + bufferWidth; i++) {
                            BufferArea.Add(new List<Point>());

                            for (int k = 0; k < bufferWidth ; k++) {
                                BufferArea[i].Add(bufferTop[i + bufferWidth][k]);
                            }

                            for (int k = (int) Math.Floor(y) - bufferWidth; k < Height; i++) {
                                BufferArea[i].Add(GetPoint(i, k));
                            }
                        }
                    }
                    else {// Tob and Bottom Buffer Intersection
                        for (int i = (int) Math.Floor(x) - bufferWidth; i < Math.Ceiling(x) + bufferWidth; i++) {
                            BufferArea.Add(new List<Point>());
                            for (int k = (int) Math.Abs(Math.Floor(y) - bufferWidth); k >= 0; k--) {
                                BufferArea[i].Add(bufferTop[i + bufferWidth][k]);
                            }
                            for (int k = 0; k < Width; k++)
                            {
                                BufferArea[i].Add(GetPoint(i, k));
                            }
                            for (int k = 0; k < (int) Math.Floor(y) - bufferWidth; k++)
                            {
                                BufferArea[i].Add(bufferBottom[i + bufferWidth][k]);
                            }
                        }
                    }
                }
            }
            else {
                if (y > bufferWidth) { 
                    if (y < Height - bufferWidth) { // right only buffer intersection
                        
                    }
                    else { // right and bottom buffer intersection
                        
                    }
                }
                else {
                    if (y < Height - bufferWidth) { // right and top buffer intersection
                        
                    }
                    else { // right, top, and bottom buffer intersection
                        
                    }
                }
            }
        }
        else {
            if (x < Width - bufferWidth) {
                if (y > bufferWidth) { 
                    if (y < Height - bufferWidth) { // left buffer intersection
                        
                    }
                    else { // left and bottom buffer intersection
                        
                    }
                }
                else {
                    if (y < Height - bufferWidth) { // left and top buffer intersection
                        
                    }
                    else { // left, top, bottom buffer intersection
                        
                    }
                }
            }
            else {
                 if (y > bufferWidth) { 
                    if (y < Height - bufferWidth) { // left and right buffer intersection
                        
                    }
                    else { // left, right, and bottom buffer intersection
                        
                    }
                }
                else {
                    if (y < Height - bufferWidth) { // left, right, and top buffer intersection
                        
                    }
                    else { // all buffer intersection
                        
                    }
                }
            }
        }


        return BufferArea;
    }

}