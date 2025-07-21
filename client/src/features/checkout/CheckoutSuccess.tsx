import { Typography } from "@mui/material";
import type { Order } from "@stripe/stripe-js";
import { useLocation } from "react-router-dom";

export default function CheckoutSuccess() {
  const { state } = useLocation();
  const order = state as Order;

  return <Typography variant="h5">{JSON.stringify(order, null, 2)}</Typography>;
}
