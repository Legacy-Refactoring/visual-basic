Module Legacy

    Sub register_customer(username As String, email As String, password As String, full_name As String, Optional phone As String = "", Optional country As String = "RS", Optional city As String = "", Optional address As String = "")
    End Sub

    Sub login_customer(username As String, password As String)
    End Sub

    Sub get_customer(customer_id As String)
    End Sub

    Sub update_customer_profile(customer_id As String, new_email As String, new_phone As String, new_address As String)
    End Sub

    Sub reset_password(email As String, new_password As String)
    End Sub

    Sub verify_email(token As String)
    End Sub

    Sub add_payment_method(customer_id As String, type As String, card_number As String, expiry_month As String, expiry_year As String, cvv As String, holder_name As String, Optional iban As String = "")
    End Sub

    Sub list_payment_methods(customer_id As String)
    End Sub

    Sub delete_payment_method(pm_id As String)
    End Sub

    Sub process_payment(customer_id As String, payment_method_id As String, amount As String, Optional currency As String = "EUR", Optional external_order_id As String = Nothing, Optional ip As String = Nothing)
    End Sub

    Sub list_payments(customer_id As String)
    End Sub

    Sub get_payment_details(payment_id As String)
    End Sub

    Sub create_refund(payment_id As String, amount As String, Optional reason As String = "customer request")
    End Sub

    Sub process_refund(refund_id As String)
    End Sub

    Sub simulate_chargeback(payment_id As String, amount As String, Optional reason As String = "fraud")
    End Sub

    Sub resolve_chargeback(chargeback_id As String, Optional won As String = "true")
    End Sub

    Sub create_fraud_review(payment_id As String, customer_id As String, Optional score As String = "85")
    End Sub

    Sub decide_fraud_review(review_id As String, decision As String, reviewer_email As String, reviewer_password As String)
    End Sub

    Sub admin_list_all_customers()
    End Sub

    Sub admin_export_all_data()
    End Sub

    Sub search_payments(search_term As String)
    End Sub

    Sub process_recurring_billing()
    End Sub

    Sub handle_webhook(payload As String)
    End Sub

    Sub ban_customer(customer_id As String)
    End Sub

    Sub generate_api_key(customer_id As String)
    End Sub

End Module
